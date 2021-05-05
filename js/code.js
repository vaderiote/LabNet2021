$(document).ready(function () {
    //FUNCION PARA LIMPIAR CAMPOS
    $('#limpiar').click(function () {
        $('input[type="text"]').val('');
    });

    //VALIDACION DE CAMPOS INGRESADOS
    $("#enviar").click(function(){
        var nombre = $("nombre").val();
        var apellido = $("#apellido").val();
        var edad = $("#edad").val();
        var empresa = $("#empresa").val();

        if(nombre == ""){
            $(alert("No ingresaste nombre"));
            return false;
        }else if(apellido == ""){
            $(alert("No ingresaste apellido"));
        }else if (edad == ""){
            $(alert("No ingresaste edad"));
        }else if (empresa == ""){
            $(alert("No ingresaste la empresa"));
        }else{}
    })

});
