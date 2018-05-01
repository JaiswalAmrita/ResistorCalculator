$(document).ready(function () {

    //Default color load for bands
    $("select").each(function () {
        BandBackgroundColor($(this));
    });

    //Setting up the value for dropdown list color items
    $("select option").each(function () {
        BandBackgroundColor($(this));
    });

    //Setting up the band value background color based on selected value
    function BandBackgroundColor(object) {
        var color = "black";

        //Setting up the Resistor image bands value based on the item select from dropdown list
        switch (object.attr('id')) {
            case "FirstBand":
                SetFigureBandColor($("#BandFirst"), object);
                break;
            case "SecondBand":
                SetFigureBandColor($("#BandSecond"), object);
                break;
            case "ThirdBand":
                SetFigureBandColor($("#BandThird"), object);
                break;
            case "FourthBand":
                SetFigureBandColor($("#BandFourth"), object);
                break;
            default:
        }

        // Setting up the background color value 
        if (object.val() != '') {

            object.css('background-color', object.val());

            switch (object.val()) {
                case "black":
                    color = "white";
                    break;
                case "red":
                    color = "white";
                    break;
                case "green":
                    color = "white";
                    break;
                case "brown":
                    color = "white";
                    break;
                case "blue":
                    color = "white";
                    break;
                case "gray":
                    color = "white";
                    break;
                default:

            }
            object.css('color', color);
        }
    }

    //Setting up the Resistor image bands value based on the item select from dropdown list
    function SetFigureBandColor(figureObject, selectObj) {
        var className = figureObject.attr('class').split(' ');
        figureObject.addClass(selectObj.val()).removeClass(className[1]);
    }

    //function called when value change in the dropdown list box for color selection
    $("select").change(function () {

        BandBackgroundColor($(this));

        var data = JSON.stringify({
            'bandAColor': $('#FirstBand').val(),
            'bandBColor': $('#SecondBand').val(),
            'bandCColor': $('#ThirdBand').val(),
            'bandDColor': $('#FourthBand').val()
        });

        // ajax call for returning the calculated values based on the provided color band items
        $.ajax({
            type: "POST",
            url: "/Home/getCaluclatedResistorValue",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: data,
            success: function (result) {
                //if error
                if (result.error != undefined) {
                    $("#errorDiv").html(result.error);
                }
                else {
                    $("#errorDiv").empty();
                    $("#txtMinResistance").val(result.minResistance);
                    $("#txtMaxResistance").val(result.maxResistance);
                    $("#txtResistorValue").val(result.resistorvalue);
                    $("#txtTolerance").val(result.toleranceValue);
                }
            }
        });
    });

})