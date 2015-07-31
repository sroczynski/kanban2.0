
$(document).ready(function () {
    trocaProjetoEvent();
    TarefaEdicaoEvent();

});

function trocaProjetoEvent()
{
    
}

function TarefaEdicaoEvent()
{
    var postit = jQuery('.post-it');
    jQuery.each(postit, function () {
        var tarefaId = $(this).find('#tarefaId').val();
        $(this).find('.open-modal').click(function () {

            $.post("/Tarefa/EditarBuscar", { tarefaId: tarefaId })
            .done(
                function (html) {
                    var modal = $('#ModalFull').clone();
                    modal.find('#conteudoModalFull').html(html);
                    $(modal).modal('show');
                }
            );
        });
    });
}

function onSuccess(data) {
    if (data.success) {
        alert(data.Message);
    }
}


