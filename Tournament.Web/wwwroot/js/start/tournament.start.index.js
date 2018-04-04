$(function () {
    //TODO
    //Gör som på boka med en specifik utils.api där man kan anropa makeauthedrequest
    $.ajax({
        method: "POST",
        url: "http://localhost:50895/api/user",
        data: {
            UserName : "First user"
        }
    }).done(function (data) {
        console.log(data);
    }).fail(function (error) {
        console.log(error);
    });;
});