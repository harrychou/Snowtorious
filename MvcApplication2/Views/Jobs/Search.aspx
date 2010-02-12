<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.SearchResultViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Search
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Search Result - page <%= Model.PagingInfo.CurrentPage %></h2>

    <p><i><%= String.Format("Results {0} - {1} of {2} for {3}", Model.PagingInfo.FirstResultIndex, Model.PagingInfo.LastResultIndex, Model.PagingInfo.TotalResults, Model.Query) %></i></p>
    
    <table>
        <tr>
            <th>
                ID
            </th>
            <th>
                Title
            </th>
            <th>
                Salary
            </th>
            <th>
                Location
            </th>
            <th>
                Member Only Download
            </th>
        </tr>

    <% foreach (var item in Model.Results) { %>
    
        <tr>
            <td>
                <%= Html.Encode(item.JobAdID) %>
            </td>
            <td>
                <%= Html.Encode(item.Title) %>
            </td>
            <td>
                <%= Html.Encode(String.Format("{0:F}", item.Salary)) %>
            </td>
            <td>
                <%= Html.Encode(item.Location) %>
            </td>
            <td>
                <%= Html.ActionLink("Details (PDF)", "DownloadJobDetails", new { item.JobAdID })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
    Page:
    <% for (int i = 1; i <= Model.PagingInfo.PageCount; i++) { %>
        <% if (i == Model.PagingInfo.CurrentPage){ %>  
            <b><%= i %></b>
        <% } else { %>
            <%= Html.ActionLink(i.ToString(), "Search", new {query = Model.Query, page = i}) %>
        <% } %>
    <% } %>
    </p>

</asp:Content>

