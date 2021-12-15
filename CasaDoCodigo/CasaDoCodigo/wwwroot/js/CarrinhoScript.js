class Carrinho
{
    GetProductElement(productCode) {
        return document.getElementById(productCode);
    }

    IncrementAmount(productCode) {

        $.ajax({
            url: '/Pedido/IncreaseProductAmount',
            type: 'POST',
            dataType: 'JSON',
            async: false,
            data: {
                request: {
                    productCode: productCode
                }
            },
            success: function (data) {  
                document.getElementById('amount_' + productCode).value++;
            },
        });

        var amount = document.getElementById('amount_' + productCode).value;

        this.CalculateSubtotal(productCode, amount);
        this.CalculateTotal();
    }

    DecrementAmount(productCode) {
        var amount = document.getElementById('amount_' + productCode).value;

        if (amount == 1) {
            alert('Não é possível selecionar uma quantidade menor do que 1!');
            return;
        }

        $.ajax({
            url: '/Pedido/DecreaseProductAmount',
            type: 'POST',
            dataType: 'JSON',
            async: false,
            data: {
                request: {
                    productCode: productCode
                }
            },
            success: function (data) {
                document.getElementById('amount_' + productCode).value--;
            },
        });
        

        this.CalculateSubtotal(productCode, amount);
        this.CalculateTotal();
    }

    SetAmount(productCode, element) {

        var amount = element.value;

        if (amount < 1) {
            alert('Não é possível selecionar uma quantidade menor do que 1!');
            amount = 1;
            document.getElementById('amount_' + productCode).value =1;
        }

        
        $.ajax({
            url: '/Pedido/UpdateProductAmount',
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

        this.CalculateSubtotal(productCode, amount);
        this.CalculateTotal();
    }

    CalculateSubtotal(productCode, quantidade) {

        var preco = document.getElementById('preco_' + productCode).textContent.replace(/\D+/g, '');
        var total = Number(preco / 100) * Number(quantidade);
        $('#subtotal_' + productCode).text(total.toFixed(2));
    }

    CalculateTotal() {
        var elements = document.getElementsByClassName('subtotal');

        var total = 0;

        Array.prototype.forEach.call(elements, function (element) {
            total += (Number(element.textContent.replace(/\D+/g, '')) / 100);
        })

        document.getElementById('total').textContent = total.toFixed(2);
    }
}

var carrinho = new Carrinho();