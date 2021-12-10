class Carrinho
{


    IncrementAmount(productCode) {

        var elValue = document.getElementById(productCode).value;
        document.getElementById(productCode).value = Number(elValue)+1;

        $.ajax({
            url: '/Pedido/IncreaseProductAmount',
            type: 'POST',
            dataType: 'json',
            async: true,
            data: {
                request: {
                    productCode: productCode
                }
            }
        });
    }

    DecrementAmount(productCode) {
        $.ajax({
            url: '/Pedido/DecreaseProductAmount',
            type: 'POST',
            dataType: 'json',
            async: true,
            data: {
                request: {
                    productCode: productCode
                }
            },
            success: function (data) {
                var elValue = document.getElementById(productCode).value;
                document.getElementById(productCode).value = Number(elValue) - 1;
            }
        });
    }

    SetAmount(productCode, element) {

        var amount = element.value;

        $.ajax({
            url: '/Pedido/UpdateProductAmount',
            type: 'POST',
            dataType: 'json',
            async: true,
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