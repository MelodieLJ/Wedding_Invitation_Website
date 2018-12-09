$(document).ready(function () {

    var theForm = $("#theForm");
    //theForm.hide();

    var $OurStory = $(".OurStory");
    var $Quote = $(".Quote");
    var $Story = $(".Story");
    var $FirstRow = $(".FirstRow");
    var $SecondRow = $(".SecondRow");

    //$Quote.hide();
    //$Story.hide();
    //$OurStory.on("click", function () {
    //    $Quote.toggle(1000);
    //    $Story.toggle(1000);
    //});

   

    $SecondRow.hide();
    $FirstRow.on("click", function () {
        $SecondRow.slideToggle(300);
    });


    // Set the date we're counting down to
    var countDownDate = new Date("Mar 2, 2019 16:00:00").getTime();

    // Update the count down every 1 second
    var x = setInterval(function () {
        // Get todays date and time
        var now = new Date().getTime();
        // Find the distance between now an the count down date
        var distance = countDownDate - now;
        // Time calculations for days, hours, minutes and seconds
        var days = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((distance % (1000 * 60)) / 1000);

        // Output the result in an element with id="demo"
        document.getElementById("days").innerHTML = days;
        document.getElementById("hours").innerHTML = hours;
        document.getElementById("minutes").innerHTML = minutes;
        document.getElementById("seconds").innerHTML = seconds;

        document.getElementById("all").innerHTML = days + ": " + hours + ": " + minutes + ": " + seconds;

        // If the count down is over, write some text 
        if (distance < 0) {
            clearInterval(x);
            document.getElementById("all").innerHTML = "We're married!";
        }
    }, 1000);

 
});