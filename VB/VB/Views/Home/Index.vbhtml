@ModelType System.Collections.IEnumerable
<script type="text/javascript">
    function OnInit(s, e) {
        AdjustSize();
        ASPxClientUtils.AttachEventToElement(window, "resize", function (evt) {
            AdjustSize();
        });
    }
    function OnEndCallback(s, e) {
        AdjustSize();
    }
    function AdjustSize() {
        var height = document.documentElement.clientHeight;
        GridView.SetHeight(height);
    }
</script>
@Html.Partial("GridViewPartialView", Model)