$(function () {
    $('.filter-facetoption-chk').click(function () {
        var filterCheckbox = $(this)[0];
        var filterQuerystring;
        filterQuerystring = $(this).val();
        var currentUrl = document.location;

        if (filterCheckbox.checked === true) {
            if (currentUrl.toString().indexOf("?") < 0) {
                currentUrl = currentUrl + "?" + filterQuerystring;
            }
            else {
                currentUrl = currentUrl + filterQuerystring;
            }
        }
        else {
            currentUrl = currentUrl.toString().replace(filterQuerystring, '');
        }

        document.location = currentUrl;
    });
});

(function () {
    $('.filter-facetoption-link').click(function () {
        var filterLink = $(this)[0];
        var filterQuerystring;
        filterQuerystring = $(this).attr("original");
        var currentUrl = document.location;
        if (currentUrl.toString().indexOf("?") < 0) {
            currentUrl = currentUrl + "?" + filterQuerystring;
        }
        else {
            currentUrl = currentUrl + filterQuerystring;
        }
        document.location = currentUrl;
    });
});

jQuery(function ($) {
    var url = document.location;
    var filterCheckBoxes = $('body').find('.filter-facetoption-chk');
    $.each(filterCheckBoxes, function (obj) {
        if (url.toString().indexOf($(filterCheckBoxes[obj]).val()) > 0) {
            $(filterCheckBoxes[obj])[0].checked = true;
        }
    });
});