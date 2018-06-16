$('.wrapper-curtida').click(function () {
    $(this).toggleClass('curtido');
});

$('.slide-horizontal').slick({
    infinite: true,
    slidesToShow: 4
});

$('#abrirModalCadastroConta').click(function () {
    $('#modalLogin').modal('hide');
    $('#btnGetLocalizacao').click();
    $('#modalCadastro').modal('show');
});

$('#btnLogOff').click(function () {
    $.post('/Home/LogOff', null, function () {
        window.location.reload();
    })
});

var Post = new function () {
    let self = this;


    $('#arquivosPet').change(function () {
        self.RenderizarImagens();
    });

    $(document).on('click', 'span.image-close', function () {
        $(this).parents('.wpImagem').remove();
    });

    self.RenderizarImagens = function () {

        let inputImagens = $('#arquivosPet')[0];

        if (inputImagens.files) {

            for (let i = 0; i < inputImagens.files.length; i++) {
                let reader = new FileReader();

                reader.onload = function (event) {
                    let template = $('<div>');
                    template.addClass('col-md-4 my-2 wpImagem');

                    //templkate

                    template.append($('<span class="fa fa-trash text-danger image-close"></span>'));

                    let imagem = $('<img>');
                    imagem.addClass('img-fluid');

                    imagem.attr('src', event.target.result);

                    imagem.css('width', 135);
                    imagem.css('height', 150);

                    template.append(imagem);

                    $('#wpImages').prepend(template);
                }

                reader.readAsDataURL(inputImagens.files[i]);
            }
        }
    }

    self.RemoverImagem = function (index) {

    }

    self.CriarPost = function () {

    };

    self.UploudImage = function () {

    };
};

function readURL(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#blah').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

var Geolocalizacao = new function () {

    let self = this;

    self.UsuarioBloqueou = false;

    self.RetornarLatLong = function (fn) {
        $.getJSON('https://ipinfo.io/geo', function (data) {
            console.log(data);
            fn(data);

        }).error(function (e) { console.log('Erro: ', e) });
    };
};

var Usuario = new function () {
    let self = this;

    let latitude;
    let longitude;

    $('#btnGetLocalizacao').click(function () {

        Geolocalizacao.RetornarLatLong(function (data) {
            let arr = data.loc.split(',');
            latitude = arr[0];
            long = arr[1];

            $('#localizacaoDisplay').val(data.city + ', ' + data.region);
        });
    });

    $('#arquivoUser').change(function () {
        if (this.files && this.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                $('#previewUser').attr('src', e.target.result);
            }

            reader.readAsDataURL(this.files[0]);
        }
    });

    $('#btnCriarConta').click(function () {
        self.CriarUsuario();
    });

    let CriarModel = function () {

        let model = new FormData();
        model.append('Nome', $('#nomeUserCadastro').val());
        model.append('Email', $('#emailUserCadastro').val());
        model.append('Telefone', $('#foneUserCadastro').val());
        model.append('Senha', $('#senhaUserCadastro').val());
        model.append('ConfirmarSenha', $('#ConfirmarSenhaUserCadastro').val());
        model.append('FileUpload', $('#arquivoUser')[0].files[0])
        model.append('Latitude', latitude);
        model.append('Longitude', longitude);

        return model;
    };

    self.CriarUsuario = function () {
        let data = CriarModel();


        $.ajax({
            type: 'post',
            url: '/Usuarios/Cadastrar',
            data: data,
            dataType: 'json',
            contentType: false,
            processData: false,
            success: function (response) {
                window.location.reload();
            },
            error: function (error) {
                alert(error.statusText);
            }
        });   
    };

};