$(document).ready(
    function () {

        $.getJSON("/Service/productServices.aspx").done(
            function (data) {
                for (var i = 0; i < data.length; i++) {
                    var tableCell = "<div class=\"tableRow\"><div class=\"tableCell\"><img src=\"" + data[i].PictureUrl + "\" style=\"height:200px;width:200px;\"><input class=\"buttonShow2\" id=\"" + data[i].ID + "\" type=\"button\" value=\"Visa\" /></div></div>";
                    $("#tableDiv").append(tableCell);

                }
                

                $(".buttonShow2").click(
                    function () {
                        var url = "/pageProduct.aspx?id=" + this.id;
                        location.href = url;
                    }
                );

            }
        );

        


        $(".buttonShow").click(
            function () {
                $(window).attr('location', '/pageProduct2.aspx');
            }
        );
        $("#Clear").click(
            function () {
                
                $(window).attr('location', '/ShoppingCart.aspx');
            }
        );
        
       
        $("#goToCheckOut").click(function () {
            $(window).attr('location', '/ShoppingCart.aspx');
        });
        $("#Pay").click(function () {
            $(window).attr('location', '/Checkout.aspx');
        });

        $("#Buy").click(function () {
            $(window).attr('location', '/Ïndex.aspx');
            alert("Tack för din beställning");
        });
        $("#Cancel").click(function () {
            $(window).attr('location', '/ShoppingCart.aspx');
        });
    }
); 