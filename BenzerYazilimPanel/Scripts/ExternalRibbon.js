var MaxLength = 2200;
var ConfirmMessage = "Are you sure you want to perform the action? Unsaved html content will be lost.";
var CustomErrorText = "Custom validation fails because the HTML content&prime;s length exceeds " + MaxLength.toString() + " characters. The current length of characters: ";
var CurrentDocumentIndex = -1;
ASPxClientUtils.AttachEventToElement(window, "beforeunload", function (e) {
    if (!IsHtmlChanged() || CurrentDocumentIndex == -1)
        return;
    e.returnValue = ConfirmMessage;
    return ConfirmMessage;
});
function IsHtmlChanged() {
    return ribbon.GetItemByName('SaveChanges').GetEnabled();
}
function UpdateRibbonItems() {
    ribbon.GetItemByName("PreviousDocument").SetEnabled(listBox.GetSelectedIndex() > 0);
    ribbon.GetItemByName("NextDocument").SetEnabled(listBox.GetSelectedIndex() != (listBox.GetItemCount() - 1));
}
function SetEditingCommandEnabled(enabled) {
    ribbon.GetItemByName('SaveChanges').SetEnabled(enabled);
    ribbon.GetItemByName('CancelChanges').SetEnabled(enabled);
}
function CommandExecutedHandler(s, e) {
    var isHtmlChanged = IsHtmlChanged();
    switch (e.item.name) {
        case "PreviousDocument":
            if (isHtmlChanged && !confirm(ConfirmMessage))
                return;
            listBox.SelectIndex(listBox.GetSelectedIndex() - 1);
            break;
        case "NextDocument":
            if (isHtmlChanged && !confirm(ConfirmMessage))
                return;
            listBox.SelectIndex(listBox.GetSelectedIndex() + 1);
            break;
        case "SaveChanges":
            htmlEditor.Validate();
            if (!htmlEditor.GetIsValid())
                return;
            SetEditingCommandEnabled(false);
            htmlEditor.PerformDataCallback({ saveChanges: true, documentName: listBox.GetSelectedItem().value });
            break;
        case "CancelChanges":
            htmlEditor.PerformDataCallback({ saveChanges: false, documentName: listBox.GetSelectedItem().value });
            break;
    }
    if (!htmlEditor.GetIsValid())
        htmlEditor.SetIsValid(true)
    UpdateRibbonItems();
}
function ValidationHandler(s, e) {
    if (e.html.length > MaxLength) {
        e.isValid = false;
        e.errorText = CustomErrorText + e.html.length;
    }
}
function CustomDataCallbackHandler(s, e) {
    s.SetHtml(e.result);
    SetEditingCommandEnabled(false);
}
function SelectedIndexChangedHandler(s, e) {
    if (IsHtmlChanged() && CurrentDocumentIndex != e.index && !confirm(ConfirmMessage))
        s.SetSelectedIndex(CurrentDocumentIndex);
    else {
        CurrentDocumentIndex = e.index;
        htmlEditor.PerformDataCallback({ saveChanges: false, documentName: s.GetSelectedItem().value });
        UpdateRibbonItems();
    }
}
function HtmlEditorInitHandler(s, e) {
    UpdateRibbonItems();
    SetEditingCommandEnabled(false);
}
function ListBoxInitHandler(s, e) {
    CurrentDocumentIndex = s.GetSelectedIndex();
    htmlEditor.PerformDataCallback({ saveChanges: false, documentName: s.GetSelectedItem().value });
}
function HtmlChangedHandler(s, e) {
    if (!s.InCallback())
        SetEditingCommandEnabled(true);
}
function BeginCallbackHandler(s, e) {
    LoadingPanel.Show();
}
function EndCallbackHandler(s, e) {
    LoadingPanel.Hide();
}
