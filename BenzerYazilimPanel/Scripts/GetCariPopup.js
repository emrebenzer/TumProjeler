var moveLeft = 20;
var moveDown = 10;
function GetCariHover(event, ad) {
    $.ajax({
        url: '/DATA/GET_CARI',
        type: 'POST',
        data: JSON.stringify({ ad: ad }),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            $('#popHoverCariName').html(data.Ad);
            $('#popHoverCariCepTel').html(data.CepTel);
            $('#popHoverCariFax').html(data.Fax);
            $('#popHoverCariTel1').html(data.Tel1);
            $('#popHoverCariTel2').html(data.Tel2);
            $('#popHoverCariEmail').html(data.Email);
            $('#popHoverCariAdres').html(data.Adres + ' ' + data.Ilce + '-' + data.Il);
            if (data.Sayi > 1) {
                $('#popHoverCariUyari').html('Bu kayıt mükerrer bir kayıttır. Doğru netice vermeyebilir.');
            }
            if (data.FirmaMi) {
                $("#popHoverCariKimlik").html("Vergi Daire/No");
                $("#popHoverCariTc").html(data.VergiDairesi + "/" + data.Tc);
            }
            else {
                $("#popHoverCariKimlik").html("TC No");
                $('#popHoverCariTc').html(data.Tc);
            }


        },
        error: function (data) {
            alert(data);
        }
    });
    $('div#popHoverCari-Up').show()
       .css('top', event.pageY)
       .css('left', event.pageX)
       .appendTo('body');
}
function GetCariOut()
{ $('div#popHoverCari-Up').hide(); }

function GetCariMove(e) {

    $("div#popHoverCari-Up").css('top', e.pageY + moveDown).css('left', e.pageX + moveLeft);
}