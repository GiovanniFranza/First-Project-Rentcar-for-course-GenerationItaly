
$(document).ready(function () {
    //per aprire popup
    $('#btnSelect').click(function () {

        var url = this.href;
        var dialog = $('<iframe src="' + url + '" frameborder="0"></iframe').appendTo('body');

        // dialog può prendere impostazioni per creare dialog
        dialog.dialog({
            buttons: [
                {
                    text: "No",
                    click: function () {
                        $(this).dialog("close");
                    }
                }
            ],
            modal: true,
            title: 'Inserimento dati',
            resizable: false,
            width: '400px',
            overlay: { opacity: 0.9, background: 'black' },
            open: function (type, data) { $(this).parent().appendTo('form'); }


        });
        return false;
    });



});