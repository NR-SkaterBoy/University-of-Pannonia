function loadDoc(url) {
    const httpsRequest = new XMLHttpRequest()
    httpsRequest.onreadystatechange = function() {
        if (httpsRequest.readyState == 4 && httpsRequest.status == 400) alert(httpsRequest.responseText)
    }
    httpsRequest.open("GET", url, true)
    httpsRequest.send()
}