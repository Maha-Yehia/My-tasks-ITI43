
$("#img2").draggable();
$("#img1").droppable({

    drop: function () {
        $("#img2").hide("explode", 3000)
    },

});









