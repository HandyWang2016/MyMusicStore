/*上传文件
flag:0-歌曲 1-图片
*/
function uploadFile(flag) {
    $.ajaxFileUpload({
        url: "/Upload/Upload?flag=" + flag,
        type: "post",
        secureuri: false,
        fileElementId: "file1",
        dataType: "json",
        success: function (data, status)  //服务器成功响应处理函数
        {
            if (typeof (data.error) != 'undefined' && data.error != '') {
                alert(data.error);
            } else {
                if (flag == 0) {
                    $("#lblFilepath").html(data.filePath);
                    $("input[name=Path]").val(data.filePath);
                } else {
                    $("#imgPhoto").attr("src", data.filePath);
                    $("input[name=Photo]").val(data.filePath);
                }

                alert(data.msg);
            }
        },
        error: function (data, status, e)//服务器响应失败处理函数
        {
            alert(e);
        }
    });
}

function checkFile() {
    if ($("#lblFilepath").html() == "") {
        alert('请先上传文件');
        return false;
    }
    return true;
}