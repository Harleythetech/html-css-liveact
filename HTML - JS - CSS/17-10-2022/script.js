function test(){
    cas = document.getElementById("cas");
    zam = document.getElementById("zam");
    mac = document.getElementById("mac");
    var list = "";
    if(cas.checked){
       list = list + "Castillar";
    }if (zam.checked){
        list = list + "\nZamora";
    }if (mac.checked){
        list = list + "\nMacatuay";
    }alert(list);
}