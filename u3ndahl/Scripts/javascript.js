/*
* JavaScript
*/
/* --- Dagens VECKODAG + DATUM -------- */
function myDay() {
    var d = new Date();
    var weekday = new Array(7);
    weekday[0] = "Söndag";
    weekday[1] = "Måndag";
    weekday[2] = "Tisdag";
    weekday[3] = "Onsdag";
    weekday[4] = "Torsdag";
    weekday[5] = "Fredag";
    weekday[6] = "Lördag";

    var n = weekday[d.getDay()];
    document.getElementById("day").innerHTML = n;
}


/* ------- KONTAKTFORMULÄR -------*/


/* --------- SÖKRUTA ------------*/


/* ---------- PROGRAMLISTOR ---------*/


/*---------------JQUERY------------*/
//alt + 4 = $

//Kontaktform
var name = $("#name").val();
var email = $("#email").val();
var message = $("#message").val();

function getFields()
{
   if (name == "" && email == "" && message == ""){
    $("#name, #email, #message").css("border", "solid 2px red")  
   }
   
    else if ($("#email:empty")){
        $("#name").css("border", "solid 2px red")
    }
   else if ($("#email:empty")){
   $("#email").css("border", "solid 2px red")
    }
   else if ($("#message:empty")){
   $("#message").css("border", "solid 2px red")  
   }
   else{
       alert("Nu blev det fel...")
   };
}

//Validering för kontaktformulär
$("#submitBtn").click(function validateF() {
    var name = $("#name").val();
    var email = $("#email").val();
    var message = $("#message").val();
    $("#returnmessage").empty(); // To empty previous error/success message.
    // Checking for blank fields.
    if (name == "" || email == "" || message == "") {
    alert("Fyll i alla fält."),
    getFields();
    } 
    
    else if(!validateEmail(email)){
        //alert("Ange rätt epost."),
        $("#email").css("border", "solid 2px red");            
    }
    
    else {
        alert("Meddelandet är skickat!");
        $("#myForm")[0].reset(); // To reset form fields on success.
    }
});


