// Write your Javascript code.
$(document).ready(function(){
    var target = $(".outputtext p"); // Save so only need to look up once
    target.text(""); // clear output on startup
    $("#dotext").click(function(){
        var i, processed;
        inp = $("#usertext").val();
        processed = "";
        // URI encode, inserting spaces between tokens¦elements¦characters
        for (i = 0; i < inp.length; i++) {
            processed += encodeURIComponent(inp[i]) + " ";
        }
        target.text(processed);
        // target.text(inp);
        return false;
    })
});
