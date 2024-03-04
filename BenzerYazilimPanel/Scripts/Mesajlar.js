function MesajiBas(gonderen, icerik,id) {

    $("#mesajGonderen").html(gonderen);
    $("#mesajIcerik").html(icerik);
    $("#mesajID").val(id);
}

function GoreviBas(gonderen, icerik, id) {

    $("#GorevGorusulen").html(gonderen);
    $("#gorevIcerik").html(icerik);
    $("#gorevID").val(id);
}

function MesajiOkunduYap() {
    //Emre BENZER
    var seciliID = $("#mesajID").val();
    $.ajax({
        url: '/Home/MesajiOkunduYap',
        type: 'POST',
        data: JSON.stringify({ ID: seciliID }),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            if (data == true) {
                MesajlarTamami();
                SOHBETLER();
                
                $("#btnModelKapat").click();
            }

        }
    });

    

}

function GoreviOkunduYap() {
    //Emre BENZER
    var seciliID = $("#gorevID").val();
    $.ajax({
        url: '/Home/CompleteMeeting',
        type: 'POST',
        data: JSON.stringify({ ID: seciliID }),
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        success: function (data) {

            
            GORUSMELER();
            $("#btnGorevModelKapat").click();
            

        }
    });



}

