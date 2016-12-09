//Filename: custom.js
//Author Name: Sam Buensuceso, Sarina Luu
//Website Name: http://paramountbistro-part1.azurewebsites.net/
//File Description: custom js 

//Custom JS code

//JS to handle image modal
$(function () {
    $('.pop').on('click', function () {
        $('.imagepreview').attr('src', $(this).find('img').attr('src'));
        $('#imagemodal').modal('show');
    });
});