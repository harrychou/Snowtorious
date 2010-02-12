<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication1.Models.Post>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">PK_PostID</div>
        <div class="display-field"><%= Html.Encode(Model.PK_PostID) %></div>
        
        <div class="display-label">Title</div>
        <div class="display-field"><%= Html.Encode(Model.Title) %></div>
        
        <div class="display-label">Body</div>
        <div class="display-field"><%= Html.Encode(Model.Body) %></div>
        
    </fieldset>
    <p>

        <%=Html.ActionLink("Edit", "Edit", new { id=Model.PK_PostID }) %> |
        <%=Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

