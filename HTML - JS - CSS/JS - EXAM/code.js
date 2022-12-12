//Created November 11 2022 - Vincent Jovellano ICT201A
function load(){
    var nem = prompt("Enter Name:");
    if (nem == null){
        alert ("Please enter a value"); 
    }else{
        // prompt = Ask to enter name and outputs it at span name
        document.getElementById("name").innerHTML = "Name:" + nem;

        //Date and Month = Shows what date Month and Date Created
        const month = ["January","February","March","April","May","June","July","August","September","October","November","December"];
        var dt = new Date();
        var d = dt.getDate();
        let m = month[dt.getMonth()];
        document.getElementById("md").innerHTML = "Month & Day: " + m + " " + d;
    }
}