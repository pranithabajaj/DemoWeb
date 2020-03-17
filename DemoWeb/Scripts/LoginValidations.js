function Validate()
{
    var un = document.getElementById("txtUname").value;
    var pwd = document.getElementById("txtPwd").value;
    if (un.length == 0 || pwd.length == 0) {
        alert("Enter Username/Password");
        return false;
    }
    else
        return true;
}