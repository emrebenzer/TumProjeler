
var CLIENT_ID = googleClientId;

var SCOPES = ["https://www.googleapis.com/auth/calendar"];

function checkAuth() {
    var isLogined = gapi.auth.authorize(
      {
          'client_id': CLIENT_ID,
          'scope': SCOPES,
          'immediate': true
      }, handleAuthResult);
}

function handleAuthResult(authResult) {
    if (authResult && authResult.error) {
        loadCalendarApi();
    }
}

function handleAuthClick(event) {
    gapi.auth.authorize({ client_id: CLIENT_ID, scope: SCOPES, immediate: false }, handleAuthResult);
    returnfalse;
}

function loadCalendarApi() {
    gapi.client.load('calendar', 'v3', function () {
        gapi.auth.authorize({ client_id: CLIENT_ID, scope: SCOPES, immediate: false }, null);
    });
}
Number.prototype.toPaddedString = function (len, fillchar) {
    var result = this.toString();
    if (typeof (fillchar) == 'undefined') { fillchar = '0' };
    while (result.length < len) { result = fillchar + result; };
    return result;
}

Date.prototype.toRFC3339UTCString = function (supressFormating, supressMillis) {
    var dSep = (supressFormating ? '' : '-');
    var tSep = (supressFormating ? '' : ':');
    var result = this.getUTCFullYear().toString();
    result += dSep + (this.getUTCMonth() + 1).toPaddedString(2);
    result += dSep + this.getUTCDate().toPaddedString(2);
    result += 'T' + this.getUTCHours().toPaddedString(2);
    result += tSep + this.getUTCMinutes().toPaddedString(2);
    result += tSep + this.getUTCSeconds().toPaddedString(2);
    if ((!supressMillis) && (this.getUTCMilliseconds() > 0)) result += '.' + this.getUTCMilliseconds().toPaddedString(3);
    return result + 'Z';
}




/// <reference path="///js.live.net/v5.0/wl.js" />
var account = (function () {

    var signInButton;

    // Initialize the sign-in page.
    function init() {

        // Initialize the Live SDK APIs.
        WL.init();
        WL.Event.subscribe("auth.login", onLogin);

        // Add event handler to sign-in button.
        signInButton = document.getElementById("sign-in");
        signInButton.onclick = signIn;
    }

    // Sign the user into their Microsoft account.
    function signIn() {
        var session = WL.getSession();
        if (session) {
            log("You are already signed in!")
        }
        else {
            WL.login({ scope: "wl.basic" }).then(
                function () {
                    log("Log in successful");

                },
                function (response) {
                    log("Could not connect, status = " + response.status);
                });
        }
    }

    // Get the current session for the user's account.
    function onLogin() {
        var session = WL.getSession();
        if (session) {
            log("You are now signed in.");
        }
    }

    // Output the results to a div in the page.
    function log(message) {
        document.getElementById('output').innerText = message;
    }

    return {
        init: init
    };

})();
