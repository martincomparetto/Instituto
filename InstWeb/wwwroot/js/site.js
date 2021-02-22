// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Saludar(nombre) {
    alert("Hola " + nombre + "!!!");
}

function Sumar(num1, num2) {
    var suma = parseInt(num1) + parseInt(num2);
    document.getElementById("resultado").value = suma;
    // alert("El resultado de la suma es: " + suma);
}

$("p").on({
    mouseenter: function() {
        $(this).css("background-color", "lightgray");
    },
    mouseleave: function() {
        $(this).css("background-color", "lightblue");
    },
    click: function() {
        $(this).css("background-color", "yellow");
    }
})

function ObtenerProfesores() {
    $.ajax({
        url: "/Profesores/GetAll",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            // document.getElementById("json").value = "";
            var tabla = $('<table></table>');
            tabla.append("<thead>>Apellido y Nombre</td><td>Email</td><td>Domicilio</td></thead>");
            var body = $('<tbody></tbody>');
            var linea;
            for (var i = 0; i < response.length; i++) {
                // document.getElementById("json").value += response[i].apellidoNombre;
                linea = $('<tr></tr>')
                linea.append("<td>" + response[i].apellidoNombre + "</td>");
                linea.append("<td>" + response[i].email + "</td>");
                linea.append("<td>" + response[i].domicilio + "</td>");
                body.append(linea);
            };
            tabla.append(body);
            $("#tablaProfesores").append(tabla);
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    })
}