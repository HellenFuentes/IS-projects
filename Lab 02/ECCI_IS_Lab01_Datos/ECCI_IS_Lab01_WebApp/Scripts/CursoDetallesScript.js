function cambioCursoSelecionado(cursoId) {
    obtenerCantidadEstudiantes(cursoId);
    obtenerPromedioClase(cursoId);
}
function obtenerCantidadEstudiantes(cursoId) {
    $.get("/CursoDetalles/ObtenerCantidadEstudiantes", {
        cursoId: cursoId
    }, function (resultadoCantidadEstudiantes) {
        $('#cantidadEstudiantes').val(resultadoCantidadEstudiantes);
    });
}
function obtenerPromedioClase(cursoId) {
    $.get("/CursoDetalles/ObtenerPromedioClase", {
        cursoId: cursoId
    }, function (resultadoPromedioClase) {
        $('#promedio').val(resultadoPromedioClase);
    });
}