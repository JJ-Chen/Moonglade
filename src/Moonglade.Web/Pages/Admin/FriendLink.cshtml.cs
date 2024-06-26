using Microsoft.AspNetCore.Mvc.RazorPages;
using Moonglade.Data.Entities;
using Moonglade.FriendLink;

namespace Moonglade.Web.Pages.Admin;

public class FriendLinkModel(IMediator mediator) : PageModel
{
    public EditLinkRequest EditLinkRequest { get; set; } = new();

    public List<FriendLinkEntity> Links { get; set; }

    public async Task OnGet() => Links = await mediator.Send(new GetAllLinksQuery());
}