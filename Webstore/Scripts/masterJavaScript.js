$(document).ready(
    function () {
        $(".buttonShow").click(
            function () {
                $(window).attr('location', '/pageProduct2.aspx');
            }
        );

        $(".buttonShow2").click(
            function (
            ) {
                $(window).attr('location', '/pageProduct.aspx');
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