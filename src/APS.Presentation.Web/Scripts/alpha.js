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

var Post = new function () {
    let self = this;

    self.RenderizarImagens = function () {
        let inputImagens = $('#arquivosPet')[0];
        if (inputImagens.files) {
            for (let i = 0; i < inputImagens.files.legth; i++) {
                let reader = new FileReader();

                reader.onload = function (event) {
                    let template = $('<div>');
                    template.addClass('col-md-4 my-2');

                    //templkate


                    template.append()

                    $($.parseHTML('<img>')).attr('src', event.target.result)
                        .appendTo();
                }

                reader.readAsDataURL(input.files[i]);
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
        let model = {
            Nome: $('#nomeUserCadastro').val(),
            Email: $('#emailUserCadastro').val(),
            Telefone: $('#foneUserCadastro').val(),
            Senha: $('#senhaUserCadastro').val(),
            ConfirmarSenha: $('#ConfirmarSenhaUserCadastro').val()
        };

        return model;
    };

    self.CriarUsuario = function () {
        let data = CriarModel();
        $.post('/Usuarios/Cadastrar', data, function (data) {
            alert('Funfou!');
        }).error(function (e) {
            alert(e.statusText);
        });
    };

};