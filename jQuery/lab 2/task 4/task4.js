$.ajax({
    method: "GET",
    url: "rockbands.json",
    success: function (result) {
        $("#selectID").append(` <option >please choose name</option>`)
        for (let i in result) {
            $("#selectID").append(` <option value="${i}">${i}</option>`)
        }
        var current = 0;
        var globalBand
        $("#selectID").on('change', function (e) {
            if (current >= 1) { }
            current += 1;
            var band = $(this).val();
            globalBand = band;
            $("#artistID").append(` <option >please choose name</option>`)
            for (let i in result[band]) {
                $("#artistID").append(` <option >${result[band][i].name}</option>`)
            }

        })
        $("#artistID").on("change", function () {

            for (let i in result[globalBand]) {
                var x = $("#artistID option:selected").val();
                console.log(globalBand)
                console.log(x)
                if (result[globalBand][i].name = x)
                    console.log(result[globalBand][i])
                window.location.href = result[globalBand][i].value;

            }
        })
    }
})


