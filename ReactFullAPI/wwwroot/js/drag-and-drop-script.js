
$(document).ready(function () {

    $('.box-item').draggable({
        cursor: 'move',
        helper: "clone"
    });

    $("#container1").droppable({
        drop: function (event, ui) {
            var itemid = $(event.originalEvent.toElement).attr("itemid");
            $('.box-item').each(function () {
                if ($(this).attr("itemid") === itemid) {
                    $(this).appendTo("#container1");
                }
            });
        }
    });

    $("#container2").droppable({
        drop: function (event, ui) {
            var itemid = $(event.originalEvent.toElement).attr("itemid");
            $('.box-item').each(function () {
                if ($(this).attr("itemid") === itemid) {
                    $(this).appendTo("#container2");
                }
            });
        }
    });

});