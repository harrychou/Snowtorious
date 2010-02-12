<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication1.Models.Post>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>
    <%= Html.ValidationSummary("Edit was unsuccessful. Please correct the errors and try again.") %>
    <% using (Html.BeginForm()) {%>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.PK_PostID) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.PK_PostID) %>
                <%= Html.ValidationMessageFor(model => model.PK_PostID) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Title) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Title) %>
                <%= Html.ValidationMessageFor(model => model.Title) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Body) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Body) %>
                <%= Html.ValidationMessageFor(model => model.Body) %>
            </div>

            <div class="editor-label">
                <%= Html.LabelFor(model => model.CommentCount) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.CommentCount)%>
                <%= Html.ValidationMessageFor(model => model.CommentCount, "this is not a valid value")%>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

