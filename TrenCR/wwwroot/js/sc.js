// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//const { Alert } = require("../lib/bootstrap/dist/js/bootstrap.bundle");



// Write your JavaScript code.
$(document).ready(function () {
    

    function Fecha() {
        $.ajax({
            type: "GET",
            url: "/SC/Fecha",
            success: function (data) {
                $("#Fecha").text("Fecha : "+ data);
            },
            error: function (req, status, error) {
            }
        });
    }
    function Hora() {
        $.ajax({
            type: "GET",
            url: "/SC/Hora",
            success: function (data) {
                $("#Hora").text("Hora : "+ data);  
            },
            error: function (req, status, error) {
            }
        });
    }

    $("#AgregarBoleto").click(function ()
    {
        if ($("#Email").val().length > 0) {
            $('#bolas').append(GeneraRowTabla($("#code").val(), $("#FechaSelect").val(), $("#CantidadSelect").val(), $("#Email").val()));
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


    $("#Procesar").click(function ()
    {
        var rowCount = $('#bolas > tbody > tr').length;
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

    function InsertarBoleto() {
        $.ajax({
            type: "Post",
            url: "/Boletos/Create",
            data: { Horario: $("#code").val(), Fecha: $("#FechaSelect").val(), Cantidad: $("#CantidadSelect").val(), User: $("#Email").val(), Ruta: "1"},
            success: function (data)
            {
                if (data > 0)
                {
                    alert("Datos Ingresados Exitosamente...");
                    $("#bolas").empty();
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

