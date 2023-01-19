window.culture = {
    get: () => getCookie('culture'), //window.localStorage['culture'],
    set: (value) => setCookie('culture', value, 356) // window.localStorage['culture'] = value
};

var startedGooey = false;
function StartGooey()
{
    if (!startedGooey) {
        setTimeout(ActiveGooey, 1000);
        startedGooey = true;
    }
}
function ActiveGooey()
{
    console.log("ActiveGooey");
    $('.mask-container').addClass('gooey');
    setTimeout(DesactiveGooey, 10000);
}

function DesactiveGooey() {
    console.log("DesactiveGooey");
    $('.mask-container').removeClass('gooey');
    //setTimeout(ActiveGooey, 10000);
    setTimeout(ActiveGooeyInv, 10000);
}

function StartGooeyInv() {
    setTimeout(ActiveGooeyInv, 1000);
}
function ActiveGooeyInv() {
    console.log("ActiveGooeyInv");
    $('.mask-container').addClass('gooeyinv');
    setTimeout(DesactiveGooeyInv, 10000);
}

function DesactiveGooeyInv() {
    console.log("DesactiveGooeyInv");
    $('.mask-container').removeClass('gooeyinv');
    //setTimeout(ActiveGooeyInv, 10000);
    setTimeout(ActiveGooey, 10000);
}

function ScrollElement(element) {
    document.getElementById(element).scrollIntoView({ behavior: 'smooth' });
}

function ConfirmLeave() {
    // Enable navigation prompt
    window.onbeforeunload = function () {
        return true;
    };
    // Remove navigation prompt
    window.onbeforeunload = null;
}

function SetStyle(selector, value) {
    $(selector).attr('style', value);
}

function SetTitle(title) {
    document.title = title;
};

function GetUserAgent() {
    return navigator.userAgent;
}

function setAccordion(element) {
    $(function () {
        $(element).accordion({
            collapsible: true,
            active: 999,
            icons: { "header": "ui-icon-plus", "activeHeader": "ui-icon-minus" },
            heightStyle: "content"
        });
    });
}

function stopDefAction(evt) {
    evt.preventDefault();
    evt.stopPropagation();
}

function focusElement(id) {
    const element = document.getElementById(id);
    element.focus();
}

function GetCulture() {
    return navigator.language || navigator.userLanguage;
}

function setCookie(name, value, days) {
    //console.log("setCookie: " + name);
    var expires = "";
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        expires = "; expires=" + date.toUTCString();
    }
    document.cookie = name + "=" + (value || "") + expires + "; path=/";
}
function getCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}
function eraseCookie(name) {
    //console.log("eraseCookie: " + name);
    document.cookie = name + '=; Path=/; Expires=Thu, 01 Jan 1970 00:00:01 GMT;';
}


function GoBack() {
    window.history.go(-1)
}

function PrintObject(obj) {
    return JSON.stringify(obj);
}

async function confirm(title, message, icono) {
    const respuesta = await Swal.fire({
        title: title,
        html: message,
        icon: icono,
        //confirmButtonColor: "#E1448F",
        showCancelButton: true,
    });
    console.log("confirm:" + (respuesta.value == true));
    return respuesta.value == true;
}

async function dialog(title, message, icono) {
    const respuesta = await Swal.fire({
        title: title,
        html: message,
        icon: icono,
        //confirmButtonColor: "#E1448F",
        showCancelButton: false,
    });
    console.log("dialog:" + (respuesta.value == true));
    return respuesta.value == true;
}

function SubmitForm() {
    $("form:first").submit();
}

function Fullscreen() {
    if (document.body.requestFullscreen) {
        document.body.requestFullscreen();
    } else if (document.body.mozRequestFullScreen) { /* Firefox */
        document.body.mozRequestFullScreen();
    } else if (document.body.webkitRequestFullscreen) { /* Chrome, Safari and Opera */
        document.body.webkitRequestFullscreen();
    } else if (document.body.msRequestFullscreen) { /* IE/Edge */
        document.body.msRequestFullscreen();
    }
}


function replaceAll(str, find, replace) {
    return str.replace(new RegExp(find, 'g'), replace);
}

function AddLink(text, key, value) {
    let str = text;
    let url = new URL(document.location.href);
    url.searchParams.append(key, value);
    return str.link(url.pathname + url.search);
}

function GetBodyinnerHTML() {
    return document.body.innerHTML;
}

function SetBodyinnerHTML(innerHTML) {
    document.body.innerHTML = innerHTML;
}

function addClass(objeto, clase) {
    $(objeto).addClass(clase);
}

function removeClass(objeto, clase) {
    $(objeto).removeClass(clase);
}

function addCss(objeto, css, valor) {
    $(objeto).css(css, valor);
}

function removeCss(objeto, css) {
    $(objeto).css(css, "");
}

function focusElement(objeto) {
    alert(objeto + " " + $(objeto));
    $(objeto).focus();
}

function httpGet(theUrl) {
    let xmlHttp = new XMLHttpRequest();
    xmlHttp.open("GET", theUrl, false); // false for synchronous request
    //xmlHttp.setRequestHeader('Access-Control-Allow-Origin', 'https://www.elpoderdelvapor.com');
    xmlHttp.send(null);
    return xmlHttp.responseText;
}

//https://stackoverflow.com/questions/574944/how-to-load-up-css-files-using-javascript
function AddLink(id, link, rel) {
    if (!document.getElementById(id)) {
        let head = document.getElementsByTagName('head')[0];
        let link = document.createElement('link');
        link.id = id;
        link.rel = rel;
        //link.type = 'text/css';
        link.href = link;
        link.media = 'all';
        head.appendChild(link);
        console.log('AddLink ' + id);
    }
}

//https://medium.com/@alshakero/how-to-setup-your-web-app-manifest-dynamically-using-javascript-f7fbee899a61
function LoadManifest(url) {
    document.querySelector('#my-manifest-placeholder').setAttribute('href', url);
}

function detectBottomPage() {
    $(window).on("scroll", function () {
        var scrollHeight = $(document).height();
        var scrollPosition = $(window).height() + $(window).scrollTop();
        //if ((scrollHeight - scrollPosition) / scrollHeight === 0) {
        if ((scrollHeight - 300) < scrollPosition) {
            DotNet.invokeMethodAsync('WebClientCLM.Client', 'BottomPage');
            //console.log("BottomPage");
        }
    });
}

function setLang(lang) {
    var url = new URL(top.window.location.href.split('?')[0]);
    setCookie("lang", lang, 365);
    top.window.location.href = url;
}

function AnalyticsInitialize(lang) {
    //alert("AnalyticsInitialize " + lang);
    var firebaseConfig;
    if (lang == 'en-US') {
        firebaseConfig = {
            apiKey: "AIzaSyBRXj8x-9HTJOA1kXglloWCpzh4-0nTTFU",
            authDomain: "global-merck-atlas.firebaseapp.com",
            projectId: "global-merck-atlas",
            storageBucket: "global-merck-atlas.appspot.com",
            messagingSenderId: "1012221568789",
            appId: "1:1012221568789:web:611cf3b92f40383851eb1c",
            measurementId: "G-GD2EQTS32P"
        };
    }
    if (lang == 'es' || lang == 'en-PH') {
        firebaseConfig = {
            apiKey: "AIzaSyDxCJ4mzZA-WhRx7tCF4E5MwCYL8g7A3Ks",
            authDomain: "merck-atlas-es.firebaseapp.com",
            databaseURL: "https://merck-atlas-es.firebaseio.com",
            projectId: "merck-atlas-es",
            storageBucket: "merck-atlas-es.appspot.com",
            messagingSenderId: "81724405727",
            appId: "1:81724405727:web:4419227273a9a07123766a",
            measurementId: "G-6M227DH7XR"
        };
    }
    if (lang == "de" || lang == 'de-DE') {
        firebaseConfig = {
            apiKey: "AIzaSyBR8kU31AV-gZ3qhfK60xQ2rlHggznYhWk",
            authDomain: "merck-atlas-de.firebaseapp.com",
            databaseURL: "https://merck-atlas-de.firebaseio.com",
            projectId: "merck-atlas-de",
            storageBucket: "merck-atlas-de.appspot.com",
            messagingSenderId: "823110505799",
            appId: "1:823110505799:web:6dad928baf138fd32f6862",
            measurementId: "G-80RQKPS3C4"
        };
    }
    if (lang == 'en-GB') {
        firebaseConfig = {
            apiKey: "AIzaSyDBZtm8BEIZKfk14MrVucQh7Z7WUDHFsIk",
            authDomain: "merck-atlas-uk.firebaseapp.com",
            projectId: "merck-atlas-uk",
            storageBucket: "merck-atlas-uk.appspot.com",
            messagingSenderId: "344813365589",
            appId: "1:344813365589:web:40137ebf99486b0bcee7dc",
            measurementId: "G-DKJGXQ0W4T"
        };
    }
    
    if (lang == 'cs') {
        
        firebaseConfig = {
            apiKey: "AIzaSyDQirGg2N_YnkkuhteD-t9Y9OmA3EYrlas",
            authDomain: "merck-atlas-cz.firebaseapp.com",
            projectId: "merck-atlas-cz",
            storageBucket: "merck-atlas-cz.appspot.com",
            messagingSenderId: "584119374398",
            appId: "1:584119374398:web:501274c7eb076f60b8776f",
            measurementId: "G-8XHZL91E2T"
        };
    }

    if (lang == 'hu' || lang == 'en-TT') {
        firebaseConfig = {
            apiKey: "AIzaSyCDBeUVFtonuzCemE9JuYu_Q5j0Npz6p6Q",
            authDomain: "merck-atlas-hu.firebaseapp.com",
            projectId: "merck-atlas-hu",
            storageBucket: "merck-atlas-hu.appspot.com",
            messagingSenderId: "181962990216",
            appId: "1:181962990216:web:a2757ba4662b13c973f53d",
            measurementId: "G-G4M499E3VL"
        };
    }

    // Initialize Firebase
    if (firebaseConfig) {
        firebase.initializeApp(firebaseConfig);
        firebase.analytics();
        console.log('AnalyticsInitialize ' + lang);
    }
    
}


function AnalyticsLogin() {
    firebase.analytics().logEvent('login', {
        method: 'code'
    });
    console.log("AnalyticsLogin ok");
}

function AnalyticsPresentation(presentation) {
    firebase.analytics().logEvent('select_content', {
        item_id: presentation,
        content_type: 'presentation'
    });
    console.log("AnalyticsPresentation " + presentation);
}

function AnalyticsScreen(screen) // Main or Login
{
    firebase.analytics().logEvent('select_content', {
        item_id: screen,
        content_type: 'screen'
    });
    console.log("AnalyticsScreen " + screen);
}
function DisableFocusIn(id) // Main or Login
{
   
    //$(document).unbind("focusin");
    //$(document).unbind("focused");
    ////$("#country").focusin(function (e) {
    ////    e.preventDefault()
    ////});
    //$(document).focus(function (e) {
    //    e.preventDefault()
    //});
    //$(document).focusin(function (e) {

       
    //    $(document).unbind();
    //    e.preventDefault();
    //});
    //$(document).focus(function (e) {
    //    $(document).unbind();
    //    e.preventDefault();
    //});
    //$(document).click(function (e) {
    //    $(document).unbind();
    //    e.preventDefault();
    //});
    //$(document).mousedown(function (e) {
    //    $(document).unbind();
    //    e.preventDefault();
    //});
    //$(document).mouseup(function (e) {
    //    $(document).unbind();
    //    e.preventDefault();
    //});
    //$(document).keydown(function (e) {
    //    $(document).unbind();
    //    e.preventDefault();
    //});
    //form - control
    //$("#country").focusin(function (e) {
       
    //    $("#country").unbind();
    //    e.preventDefault();
    //});
    //$("#country").focus(function (e) {
    //    $("#country").unbind();
    //    e.preventDefault();
    //});
    //$("#country").click(function (e) {
    //    $("#country").unbind();
    //    e.preventDefault();
    //});
    //$("#country").mousedown(function (e) {
    //    $("#country").unbind();
    //    e.preventDefault();
    //});
    //$("#country").mouseup(function (e) {
    //    $("#country").unbind();
    //    e.preventDefault();
    //});
    //$("#country").keydown(function (e) {
    //    $("#country").unbind();
    //    e.preventDefault();
    //});

    //$(".form-control").focusin(function (e) {

    //    $(".form-control").unbind();
    //    e.preventDefault();
    //});
    //$(".form-control").focus(function (e) {
    //    $(".form-control").unbind();
    //    e.preventDefault();
    //});
    //$(".form-control").click(function (e) {
    //    $(".form-control").unbind();
    //    e.preventDefault();
    //});
    //$(".form-control").mousedown(function (e) {
    //    $(".form-control").unbind();
    //    e.preventDefault();
    //});
    //$(".form-control").mouseup(function (e) {
    //    $(".form-control").unbind();
    //    e.preventDefault();
    //});
    //$(".form-control").keydown(function (e) {
    //    $(".form-control").unbind();
    //    e.preventDefault();
    //});

}


/*Google*/
function googleRecaptcha(dotNetObject, selector, sitekeyValue) {
    return grecaptcha.render(selector, {
        'sitekey': sitekeyValue,
        'callback': (response) => { dotNetObject.invokeMethodAsync('CallbackOnSuccess', response); },
        'expired-callback': () => { dotNetObject.invokeMethodAsync('CallbackOnExpired', response); }
    });
};

/*Google*/
function getResponse(response) {
    return grecaptcha.getResponse(response);
}

