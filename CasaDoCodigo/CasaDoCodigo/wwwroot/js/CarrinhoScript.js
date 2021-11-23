class Carrinho
{
    IncrementAmount(productCode) {

        var elValue = document.getElementById(productCode).value;
        document.getElementById(productCode).value = Number(elValue) + 1;

        $.ajax({
            url: '/Pedido/AddProductToCart',
            type: 'POST',
            dataType: 'json',
            async: false,
            data: {
                request: {
                    productCode: productCode,
                    amount: 1
                }
            },
            success: function () {
                var elValue = document.getElementById(productCode).value;
                document.getElementById(productCode).value = Number(elValue) + 1;
            }
        });
    }

    decrementAmount(productCode) {
        $.ajax({
            url: '/Pedido/AddProductToCart',
            type: 'POST',
            dataType: 'json',
            async: false,
            data: {
                request: {
                    productCode: productCode,
                    amount: -1
                }
            },
            success: function () {
                var elValue = document.getElementById(productCode).value;
                document.getElementById(productCode).value = Number(elValue) - 1;
            }
        });
    }

    SetAmount(productCode, element) {

        var amount = element.value;

        $.ajax({
            url: '/Pedido/PlusButtonAction',
            type: 'POST',
            dataType: 'json',
            async: false,
            data: {
                request: {
                    productCode: productCode,
                    amount: amount
                }
            }
        });
    }
}

var carrinho = new Carrinho();