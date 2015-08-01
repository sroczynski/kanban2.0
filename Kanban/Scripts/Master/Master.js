
$(document).ready(function () {
    trocaProjetoEvent();
    TarefaEdicaoEvent();

});

function trocaProjetoEvent() {
    var projetoIdAtual = $('#Projetos').val();
    $.post('/Sprint/GetSprints', { projetoId: projetoIdAtual },
        function (response) {
            $("#Sprints").empty();
            for (var i = 0; i < response.length; i++) { // Percorre a lista de cidades retornadas
                $('#Sprints').append('<option value="' + response[i].Value + '">' + response[i].Text + '</option>');
            };
        }
    );

    $('#Projetos').change(function () {
        var projetoId = $(this).val();
        $.post('/Home/Index', { projetoId: projetoId }, function (html) {
            var painel = $('.painel');
            painel.html($(html).find('.painel').find('#innerPainel'));

            $.post('/Sprint/GetSprints', { projetoId: projetoIdAtual },
                function (response) {
                    $("#Sprints").empty();
                    for (var i = 0; i < response.length; i++) { // Percorre a lista de cidades retornadas
                        $('#Sprints').append('<option value="' + response[i].Value + '">' + response[i].Text + '</option>');
                    };
                }
            );
        });
    });

    $('#Sprints').change(function () {
        var sprintId = $(this).val();
        var projetoId = $('#Projetos').val();

        $.post('/Home/Index', { projetoId: projetoId }, function (html) {
            var painel = $('.painel');
            painel.html($(html).find('.painel').find('#innerPainel'));
        });

    });
}

function TarefaEdicaoEvent() {
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
        var modal = $('#ModalAlert').clone();
        modal.find('.modal-body').html(data.Message);
    }
}


