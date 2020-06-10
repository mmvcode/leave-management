// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    let dt = $('.data-table');
    if (dt.length > 0) {
        Object.entries(dt).forEach((e) => {
            $(e[1]).DataTable();
        });
    }
});
