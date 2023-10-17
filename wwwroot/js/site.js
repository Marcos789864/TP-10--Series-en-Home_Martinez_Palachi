function MostrarActores(IdSerie){
    $.ajax({
        type: "POST",
        dataType: "JSON",
        url:'Home/VerDetalleActores',
        data: {IdSerie: IdSerie},
        success:
            
            function(response){
                console.log(response);
                $("#Titulo").html("Actores:");
                let texto = "";
                for(let item of response)
                {
                    texto += item.nombre + "<br>"
                }
                $("#Informacion").html(texto)
            }
    });
}


function MostrarTemporadas(IdSerie){
    $.ajax({
        type: "POST",
        dataType: "JSON",
        url: 'Home/VerDetallesTemporadas',
        data: {IdSerie: IdSerie},
        success:
       
            function(response){
                console.log(response);
                $("#Titulo").html("Temporadas:");
                let texto = "";
                for( let item of response)
                {
                    texto += (item.numeroTemporada+ ". " + item.tituloTemporada + "<br>");
                }
                $("#Informacion").html(texto);
                
            }
    });
}


function MostrarMasInfo(IdSerie){
    $.ajax({
        type: "POST",
        dataType: "JSON",
        url: 'Home/MostrarMasInfo',
        data: {IdSerie: IdSerie},
        success:
            function(response){
                $("#Titulo:").html("Mas informacion:")
                $("#Informacion").html(response.sinopsis);
            }
    });
}

