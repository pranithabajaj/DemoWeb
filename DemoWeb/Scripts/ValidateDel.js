function ValidateDel() {
    var eno = document.getElementById("txtEno").value;
    if (eno.length==0) {
        alert("enter empno");
        return false;
    }
    else
        return true;
}