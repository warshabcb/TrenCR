// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//const { Alert } = require("../lib/bootstrap/dist/js/bootstrap.bundle");



// Write your JavaScript code.
$(document).ready(function () {
    

   

    $("#AgregarBoletocs").click(function ()
    {
        if ($("#Email").val().length > 0) {
            $('#bolascs').append(GeneraRowTabla($("#code").val(), $("#FechaSelect").val(), $("#CantidadSelect").val(), $("#Email").val()));
        }
        else {
            alert('Debe de ingresar el correo Electronico.');
        }
        
    });
    
    setInterval(Fecha, 1000);
    setInterval(Hora, 1000);


    //$('#Listapro').append(
    function GeneraRowTabla(Horario, Fecha, Cantidad, User) {
        var data = "";
        data = data + "<tr><td class='text-center'>" + Horario+ "</td>";
        data = data + "<td class='text-center'>" + Fecha + "</td>";
        data = data + "<td class='text-center'>" + Cantidad + "</td>";
        data = data + "<td class='text-center'>" + User + "</td>";
        data = data + "<td class='text-center'><button  class='btn btn-sm btn-danger text-center btn_row_delete'>Delete</button></td></tr>";//onclick='eliminar(`" + data.codigo + "`)
        return data;
    }

    $(document).on('click', ".btn_row_delete", function (e) {
        var r = $(this).closest('tr').remove();
        
    });


    $("#Procesarcs").click(function ()
    {
        var rowCount = $('#bolascs > tbody > tr').length;
        var i;
        if ( rowCount > 0) {
            i = InsertarBoleto();
            console.log(i);
        }
        else
        {
            alert('No hay Datos que procesar... ');
        }
        
    });

    function InsertarBoleto() {6
        $.ajax({
            type: "Post",
            url: "/Boletos/Create",
            data: { Horario: $("#code").val(), Fecha: $("#FechaSelect").val(), Cantidad: $("#CantidadSelect").val(), User: $("#Email").val(), Ruta: "2"},
            success: function (data)
            {
                if (data > 0)
                {
                    alert("Datos Ingresados Exitosamente...");
                    $("#bolascs").empty();
                    console.log(data);
                }
                else
                {
                    alert("Se presento un problema...");
                }
            },
            error: function (req, status, error) {
            }
        });
    }
   

});

