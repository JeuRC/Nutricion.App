
document.addEventListener("click",e=>{
    let btnMenu = document.querySelector(".btn-menu");
    let panel = document.querySelector(".panel");
    let userType = document.querySelector(".userType");

    if(e.target.matches(".btn-menu")||e.target.matches(".btn-menu *")){
        btnMenu.classList.toggle("active");
        panel.classList.toggle("active");
    }

    if(e.target.matches("input[name='userType']")){
        let accountType=e.target.value;
        let selector = "."+accountType+"Sign";
        userType.classList.toggle("no-visible");
        document.querySelector(selector).classList.toggle("visible");
    }

    if(e.target.matches(".close")){
        let accountType=e.target.id;
        let selector = "."+accountType+"Sign";
        console.log(accountType);
        userType.classList.toggle("no-visible");
        document.querySelector(selector).classList.toggle("visible");
    }
})
