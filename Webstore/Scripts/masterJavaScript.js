$(document).ready(
    function () {
        $(".buttonShow").click(
            function ()
            {
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
            $(window).attr('location', '/pageProduct2.aspx');
        });
    }
); 