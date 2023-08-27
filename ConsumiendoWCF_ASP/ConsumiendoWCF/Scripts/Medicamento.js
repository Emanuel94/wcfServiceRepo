window.onload = function () {
    listarMedicamento();
}

function listarMedicamento() {

    fetch("Medicamento/listarmedicamentos")
        .then(p => p.json())
        .then(p => {
            listar(p);
        })
}

function listar(data) {

    var contenido = "";

    contenido += "<table id='table' title='Tabla Medicamento' class='table'>";

    contenido += "<thead class='table-dark'>";

    contenido += "<tr>";

    contenido += "<th>Id Medicamento</th>";
    contenido += "<th>Nombre</th>";
    contenido += "<th>Concentración</th>";
    contenido += "<th>Forma Farmaceutica</th>";
    contenido += "<th>Stock</th>";
    contenido += "<th>Precio</th>";
    contenido += "<th>Presentación</th>";
    contenido += "<th>Eliminar</th>";
    contenido += "<th>Editar</th>";
    contenido += "</tr>";

    contenido += "</thead> ";
    //Contenido

    contenido += "<tbody>";
    for (elements of data) {
        contenido += "<tr>";
        contenido += "<td>" + elements.IIdMedicamento + "</td>";
        contenido += "<td>" + elements.nombre + "</td>";
        contenido += "<td>" + elements.concentracion + "</td>";
        contenido += "<td>" + elements.nombreFormaFarmaceutica + "</td>";
        contenido += "<td>" + elements.stock + "</td>";
        contenido += "<td>" + elements.Precio + "</td>";
        contenido += "<td>" + elements.presentacion + "</td>";
        contenido += "<td> <input type='button' onClick='eliminar(" + elements.IIdMedicamento +")' class='btn btn-danger' value='Eliminar'/></td>";
        contenido += "<td> <input type='button' onClick='abrirModal(" + elements.IIdMedicamento + ")' class='btn btn-primary' value='Editar' data-bs-toggle='modal' data-bs-target='#exampleModal'/></td>";
        contenido += "</tr>";

    }
    contenido += "</tbody>";


    contenido += "</table>";

    document.getElementById("container-table").innerHTML = contenido;

    new DataTable('#table', {
        responsive: true
    });

}

function abrirModal(idMedicamento) {
    limpiar();
    listarFormaFarmaceutica();
    var titulo = "";
    if (idMedicamento == 0) {
        titulo = "Agregar Medicamento";
        document.getElementById("lb-titulo").innerHTML = titulo;


    } else {
        titulo = "Editar Medicamento";
        document.getElementById("lb-titulo").innerHTML = titulo;

        fetch("Medicamento/recuperarMedicamento/?idMedicamento=" + idMedicamento)
            .then(res => res.json())
            .then(res => {

                document.getElementById("idMedicamento").value = res.IIdMedicamento;
                document.getElementById("idNombre").value = res.Nombre;
                document.getElementById("idConcentracion").value = res.concentracion;
                document.getElementById("idFormaFarmaceutica").value = res.iidFormafarmaceutica;
                document.getElementById("idPrecio").value = res.Precio;
                document.getElementById("idStock").value = res.stock;
            });

    }
}

function listarFormaFarmaceutica() {

    $.ajax({
        type: "GET",
        url: "https://localhost:44323/Medicamento/listarFormaFarmaceutica",
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            loadSelect(response);
        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });

}

function loadSelect(dataResult) {
    var contenido = "";

    for (element of dataResult) {
        contenido += "<option value='" + element.iidFormafarmaceutica + "'>" + element.Nombre + "</option>";
        document.getElementById("idFormaFarmaceutica").innerHTML = contenido;
    }
}

function limpiar() {

    var limpiar = document.getElementsByClassName("Limpiar");

    for (var i = 0; i < limpiar.length; i++) {
        limpiar[i].value = "";
    }
}

function validarCamposObligatorios() {
    var exito = true;
    var contenido = "<ol style='color:red'>";
    var obligatorios = document.getElementsByClassName("obligatorio");
    for (i = 0; i < obligatorios.length; i++) {
        if (obligatorios[i].value == "") {
            exito = false;
            contenido += "<li>" + obligatorios[i].name + " es obligatorio</li>";
        }
    }
    contenido += "</ol>";
    return { exito, contenido };
}

function guardar() {

    if (confirm("¿Desea guardar los cambios?") == 1) {

        var objeto = validarCamposObligatorios();

        if (objeto.exito == false) {
            document.getElementById("divError").innerHTML = objeto.contenido;
        }
        // capturar los valores..
        var IIdMedicamento = document.getElementById("idMedicamento").value;
        var nombre = document.getElementById("idNombre").value;
        var concentracion = document.getElementById("idConcentracion").value;
        var iidFormaFarmaceutica = document.getElementById("idFormaFarmaceutica").value;
        var Precio = document.getElementById("idPrecio").value;
        var stock = document.getElementById("idStock").value;
        var presentacion = document.getElementById("idPresentacion").value;
 

        //Llamada al controller

        var objecto = {
            IIdMedicamento,
            nombre,
            concentracion,
            Precio,
            stock,
            presentacion,
            iidFormaFarmaceutica  

        }
        fetch("Medicamento/agregarYActualizarMedicamento",{

            headers: {
                'Content-Type': 'application/json'
            },
            method: "POST",
            body: JSON.stringify(objecto)
        }).then(res => res.json())
            .then(resp => {
                if (resp == 1) {
                    listarMedicamento();
                    document.getElementById("btn-modal-cerrar").click();
                    alert("Se guardó correctamente");
                } else {
                    alert("Hubo un error inesperado");
                }
      
                
            })
    }

}

function filtrarDatos() {

    var resultFiltrado = document.getElementById("filtroNombre").value;

    if (resultFiltrado != "") {
        fetch("Medicamento/listarmedicamentosPorNombre/?nombreMedicamento=" + resultFiltrado)
            .then(res => res.json())
            .then(res => {
                listar(res);
            });

    } else {
        listarMedicamento();
    }
}

function eliminar(iidMedicamento) {
    if (confirm("Seguro desea eliminar el Medicamento") == 1) {

        fetch("Medicamento/eliminarMedicamento?iidMedicamento=" + iidMedicamento)
            .then(res => res.json())
            .then(res => {
                if (res == 1) {
                    listarMedicamento();
                    alert("Se elimino correctamente.");

                } else {
                    alert("No se elimino correctamente.");
                }
            })
    } 

}