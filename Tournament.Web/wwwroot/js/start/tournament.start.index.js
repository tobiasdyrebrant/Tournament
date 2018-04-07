$(function () {
    //TODO
    //Gör som på boka med en specifik utils.api där man kan anropa makeauthedrequest
    $.ajax({
        type: "POST",
        url: "http://localhost:50895/api/user",
        contentType: 'application/json',
        data: JSON.stringify({
            "UserName" : "dankest"
        })  
    }).done(function (data) {
        console.log(data);
    }).fail(function (error) {
        console.log(error);
    });;
});