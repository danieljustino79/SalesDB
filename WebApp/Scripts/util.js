function GetQueryStringByKey(key){
    var qs = window.location.search.substring(1);

    var vet = qs.split('&');

    for (var i = 0; i < vet.length; i++){
        var pair = vet[i].split('=');

        if (pair[0] == key){
            return pair[1];
        }
    }
}

function GetQueryStringBool(key){
    var qs = window.location.search.substring(1);

    var vet = qs.split('&');

    for (var i = 0; i < vet.length; i++){
        var pair = vet[i].split('=');

        if (pair[0] == key){
            return true;
        }
        else{
            return false;
        }
    }
}