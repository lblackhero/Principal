// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Back to top animation
$(document).ready(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() > 50) {
            $('#back-to-top').fadeIn(500);
        }
        else {
            $('#back-to-top').fadeOut(300);
        }
    });
    // scroll body to 0px on click
    $('#back-to-top').click(function () {
        $('body,html').animate({
            scrollTop: 0
        }, 400);
        return false;
    });

    $("[href]").each(function () {
        if (this.href == window.location.href) {
            $(this).addClass("active");
        }
    });

});

(function () {
    $('#msbo').on('click', function () {
        $('body').toggleClass('msb-x');
    });
}());

// sidebar animation / toggler arrow
window.addEventListener('DOMContentLoaded', event => {

    // Toggle the side navigation
    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    if (sidebarToggle) {
        // Uncomment Below to persist sidebar toggle between refreshes
        // if (localStorage.getItem('sb|sidebar-toggle') === 'true') {
        //     document.body.classList.toggle('sb-sidenav-toggled');
        // }
        sidebarToggle.addEventListener('click', event => {
            event.preventDefault();
            document.body.classList.toggle('sb-sidenav-toggled');
            localStorage.setItem('sb|sidebar-toggle', document.body.classList.contains('sb-sidenav-toggled'));
        });
    }

});

// Animation for the arrow that hides the sidebar
(function (document) {

    var div = document.getElementById('containerArrow');
    var icon = document.getElementById('icon');
    var open = false;

    if (div) {

        div.addEventListener('click', function () {
            if (open) {
                icon.className = 'fa fa-arrow-left';
            } else {
                icon.className = 'fa fa-arrow-left open';
            }

            open = !open;
        });
    }

})(document);

function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
}

