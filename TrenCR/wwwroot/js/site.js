// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    

    function Fecha() {
        $.ajax({
            type: "GET",
            url: "/SC/Fecha",
            success: function (data) {
                $("#Fecha").text("Fecha : " + data);
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
                $("#Hora").text("Hora : " + data);
            },
            error: function (req, status, error) {
            }
        });
    }
   

});

