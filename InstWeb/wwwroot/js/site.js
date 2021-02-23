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

var listaProfesores;
var nroPagina = 0;
var cantPaginas = 0;
var cantRegistrosPagina = 20;

function ObtenerProfesores() {
    $.ajax({
        url: "/Profesores/GetAll?page=" + nroPagina + "&take=" + cantRegistrosPagina,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            listaProfesores = response.profesores;
            cantPaginas = Math.round(response.cantidadRegistros / cantRegistrosPagina);
            ArmarTabla();
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    })
}

function ArmarTabla() {
    $("#tablaProfesores").remove();
    var tabla = $('<table id="tablaProfesores" class="table"></table>');
    tabla.append("<thead><td>Apellido y Nombre</td><td>Email</td><td>Domicilio</td></thead>");
    var body = $('<tbody></tbody>');
    var linea;
    // var inicio = (nroPagina * cantRegistrosPagina);
    // var fin = inicio + cantRegistrosPagina;
    // for (var i = inicio; i < fin; i++) {
    for (var i = 0; i < listaProfesores.length; i++) {
        linea = $('<tr></tr>')
        linea.append("<td>" + listaProfesores[i].apellidoNombre + "</td>");
        linea.append("<td>" + listaProfesores[i].email + "</td>");
        linea.append("<td>" + listaProfesores[i].domicilio + "</td>");
        body.append(linea);
    };
    tabla.append(body);
    $("#divTablaProfesores").append(tabla);
    $("#labelNroPagina").text("Pagina " + (nroPagina + 1) + " de " + cantPaginas);

    $("#buttonAnterior").prop('disabled', (nroPagina == 0));
    $("#buttonPrimera").prop('disabled', (nroPagina == 0));
    $("#buttonSiguiente").prop('disabled', (nroPagina == (cantPaginas - 1)));
    $("#buttonUltima").prop('disabled', (nroPagina == (cantPaginas - 1)));
}

function PaginaAnterior() {
    nroPagina = nroPagina - 1;
    ObtenerProfesores();
    // ArmarTabla();
}

function PaginaSiguiente() {
    nroPagina = nroPagina + 1;
    ObtenerProfesores();
    // ArmarTabla();
}

function PaginaPrimera() {
    nroPagina = 0;
    ObtenerProfesores();
    // ArmarTabla();
}

function PaginaUltima() {
    nroPagina = cantPaginas - 1;
    ObtenerProfesores();
    // ArmarTabla();
}