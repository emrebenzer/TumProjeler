function NewAlert(baslik, mesaj, tur) {
    if (tur == "error") {
        $.alert({
            title: baslik,
            content: '<div class="form-group"><span class="text-error">' + mesaj + '</span></div>',
            autoClose: 'confirm|3000',
            confirm: function () {
                $.unblockUI();
            }
        });
    }
    else if (tur == "success") {
        $.alert({
            title: baslik,
            content: '<div class="form-group"><span class="text-success">' + mesaj + '</span></div>',
            autoClose: 'confirm|3000',
            confirm: function () {
                $.unblockUI();
            }
        });
    }
    else {
        $.alert({
            title: baslik,
            content: '<div class="form-group"><span class="text-info">' + mesaj + '</span></div>',
            autoClose: 'confirm|3000',
            confirm: function () {
                $.unblockUI();
            }
        });
    }

};