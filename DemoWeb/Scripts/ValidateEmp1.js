function ValidateEmp1() {
    var eno = document.getElementById("txtEno").value;
    
    var job = document.getElementById("txtJob").value;
    var mgr = document.getElementById("txtMgr").value;
    
    var sal = document.getElementById("txtSal").value;
    var com = document.getElementById("txtComm").value;
    var dno = document.getElementById("txtDno").value;
    if (eno.length == 0 || ename.length == 0 || job.length == 0 || mgr.length == 0 || hdate.length == 0 || sal.length == 0 || com.length == 0 || dno.length == 0) {
        alert("enter all values");
        return false;
    }
    else
        return true;

}