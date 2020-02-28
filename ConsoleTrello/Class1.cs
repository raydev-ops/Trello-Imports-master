﻿using System;
using System.Web.UI.WebControls;

namespace ConsoleTrello
{
    public class Trellos
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public object descData { get; set; }
        public bool closed { get; set; }
        public string idOrganization { get; set; }
        public Limits limits { get; set; }
        public bool pinned { get; set; }
        public bool starred { get; set; }
        public string url { get; set; }
        public Prefs prefs { get; set; }
        public string shortLink { get; set; }
        public bool subscribed { get; set; }
        public Labelnames labelNames { get; set; }
        public object[] powerUps { get; set; }
        public DateTime dateLastActivity { get; set; }
        public DateTime dateLastView { get; set; }
        public string shortUrl { get; set; }
        public object[] idTags { get; set; }
        public object datePluginDisable { get; set; }
        public object creationMethod { get; set; }
        public string ixUpdate { get; set; }
        public object templateGallery { get; set; }
        public bool enterpriseOwned { get; set; }
        public Action[] actions { get; set; }
        public Card1[] cards { get; set; }
        public Label1[] labels { get; set; }
        public List1[] lists { get; set; }
        public Member2[] members { get; set; }
        public object[] checklists { get; set; }
        public object[] customFields { get; set; }
        public Membership[] memberships { get; set; }
        public object[] pluginData { get; set; }
    }

    public class Limits
    {
        public Attachments attachments { get; set; }
        public Boards boards { get; set; }
        public Cards cards { get; set; }
        public Checklists checklists { get; set; }
        public Checkitems checkItems { get; set; }
        public Customfields customFields { get; set; }
        public Customfieldoptions customFieldOptions { get; set; }
        public Labels labels { get; set; }
        public Lists lists { get; set; }
        public Stickers stickers { get; set; }
        public Reactions reactions { get; set; }
    }

    public class Attachments
    {
        public Perboard perBoard { get; set; }
        public Percard perCard { get; set; }
    }

    public class Perboard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Percard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Boards
    {
        public Totalmembersperboard totalMembersPerBoard { get; set; }
    }

    public class Totalmembersperboard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Cards
    {
        public Openperboard openPerBoard { get; set; }
        public Openperlist openPerList { get; set; }
        public Totalperboard totalPerBoard { get; set; }
        public Totalperlist totalPerList { get; set; }
    }

    public class Openperboard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Openperlist
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Totalperboard
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Totalperlist
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Checklists
    {
        public Perboard1 perBoard { get; set; }
        public Percard1 perCard { get; set; }
    }

    public class Perboard1
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Percard1
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Checkitems
    {
        public Perchecklist perChecklist { get; set; }
    }

    public class Perchecklist
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Customfields
    {
        public Perboard2 perBoard { get; set; }
    }

    public class Perboard2
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Customfieldoptions
    {
        public Perfield perField { get; set; }
    }

    public class Perfield
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Labels
    {
        public Perboard3 perBoard { get; set; }
    }

    public class Perboard3
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Lists
    {
        public Openperboard1 openPerBoard { get; set; }
        public Totalperboard1 totalPerBoard { get; set; }
    }

    public class Openperboard1
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Totalperboard1
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Stickers
    {
        public Percard2 perCard { get; set; }
    }

    public class Percard2
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Reactions
    {
        public Peraction perAction { get; set; }
        public Uniqueperaction uniquePerAction { get; set; }
    }

    public class Peraction
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Uniqueperaction
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Prefs
    {
        public string permissionLevel { get; set; }
        public bool hideVotes { get; set; }
        public string voting { get; set; }
        public string comments { get; set; }
        public string invitations { get; set; }
        public bool selfJoin { get; set; }
        public bool cardCovers { get; set; }
        public bool isTemplate { get; set; }
        public string cardAging { get; set; }
        public bool calendarFeedEnabled { get; set; }
        public string background { get; set; }
        public string backgroundImage { get; set; }
        public Backgroundimagescaled[] backgroundImageScaled { get; set; }
        public bool backgroundTile { get; set; }
        public string backgroundBrightness { get; set; }
        public string backgroundBottomColor { get; set; }
        public string backgroundTopColor { get; set; }
        public bool canBePublic { get; set; }
        public bool canBeEnterprise { get; set; }
        public bool canBeOrg { get; set; }
        public bool canBePrivate { get; set; }
        public bool canInvite { get; set; }
    }

    public class Backgroundimagescaled
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Labelnames
    {
        public string green { get; set; }
        public string yellow { get; set; }
        public string orange { get; set; }
        public string red { get; set; }
        public string purple { get; set; }
        public string blue { get; set; }
        public string sky { get; set; }
        public string lime { get; set; }
        public string pink { get; set; }
        public string black { get; set; }
    }

    public class Action
    {
        public string id { get; set; }
        public string idMemberCreator { get; set; }
        public Data data { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
        public Limits1 limits { get; set; }
        public Membercreator memberCreator { get; set; }
        public Member1 member { get; set; }
    }

    public class Data
    {
        public Old old { get; set; }
        public Card card { get; set; }
        public Board board { get; set; }
        public List list { get; set; }
        public Checklist checklist { get; set; }
        public Checkitem checkItem { get; set; }
        public Listbefore listBefore { get; set; }
        public Listafter listAfter { get; set; }
        public string text { get; set; }
        public string idMember { get; set; }
        public Member member { get; set; }
        public bool deactivated { get; set; }
        public Textdata textData { get; set; }
        public DateTime dateLastEdited { get; set; }
        public string memberType { get; set; }
        public string idMemberAdded { get; set; }
        public Organization organization { get; set; }
    }

    public class Old
    {
        public bool closed { get; set; }
        public string name { get; set; }
        public string idList { get; set; }
        public DateTime? due { get; set; }
        public int? dueReminder { get; set; }
        public float pos { get; set; }
        public string desc { get; set; }
        public bool dueComplete { get; set; }
        public Prefs1 prefs { get; set; }
    }

    public class Prefs1
    {
        public string background { get; set; }
        public string permissionLevel { get; set; }
    }

    public class Card
    {
        public bool closed { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int idShort { get; set; }
        public string shortLink { get; set; }
        public string idList { get; set; }
        public DateTime? due { get; set; }
        public int? dueReminder { get; set; }
        public float pos { get; set; }
        public string desc { get; set; }
        public bool dueComplete { get; set; }
    }

    public class Board
    {
        public string id { get; set; }
        public string name { get; set; }
        public string shortLink { get; set; }
        public Prefs2 prefs { get; set; }
    }

    public class Prefs2
    {
        public string background { get; set; }
        public string permissionLevel { get; set; }
    }

    public class List
    {
        public string id { get; set; }
        public string name { get; set; }
        public float pos { get; set; }
    }

    public class Checklist
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Checkitem
    {
        public string id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
    }

    public class Listbefore
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Listafter
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Member
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Textdata
    {
        public Emoji emoji { get; set; }
    }

    public class Emoji
    {
    }

    public class Organization
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Limits1
    {
        public Reactions1 reactions { get; set; }
    }

    public class Reactions1
    {
        public Peraction1 perAction { get; set; }
        public Uniqueperaction1 uniquePerAction { get; set; }
    }

    public class Peraction1
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Uniqueperaction1
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Membercreator
    {
        public string id { get; set; }
        public bool activityBlocked { get; set; }
        public string avatarHash { get; set; }
        public object avatarUrl { get; set; }
        public string fullName { get; set; }
        public string idMemberReferrer { get; set; }
        public string initials { get; set; }
        public Nonpublic nonPublic { get; set; }
        public bool nonPublicAvailable { get; set; }
        public string username { get; set; }
    }

    public class Nonpublic
    {
    }

    public class Member1
    {
        public string id { get; set; }
        public bool activityBlocked { get; set; }
        public string avatarHash { get; set; }
        public object avatarUrl { get; set; }
        public string fullName { get; set; }
        public string idMemberReferrer { get; set; }
        public string initials { get; set; }
        public Nonpublic1 nonPublic { get; set; }
        public bool nonPublicAvailable { get; set; }
        public string username { get; set; }
    }

    public class Nonpublic1
    {
    }

    public class Card1
    {
        public string id { get; set; }
        public object address { get; set; }
        public object checkItemStates { get; set; }
        public bool closed { get; set; }
        public object coordinates { get; set; }
        public object creationMethod { get; set; }
        public DateTime dateLastActivity { get; set; }
        public string desc { get; set; }
        public Descdata descData { get; set; }
        public int? dueReminder { get; set; }
        public string idBoard { get; set; }
        public string[] idLabels { get; set; }
        public string idList { get; set; }
        public object[] idMembersVoted { get; set; }
        public int idShort { get; set; }
        public object idAttachmentCover { get; set; }
        public Limits2 limits { get; set; }
        public object locationName { get; set; }
        public bool manualCoverAttachment { get; set; }
        public string name { get; set; }
        public float pos { get; set; }
        public string shortLink { get; set; }
        public bool isTemplate { get; set; }
        public Badges badges { get; set; }
        public bool dueComplete { get; set; }
        public DateTime? due { get; set; }
        public string email { get; set; }
        public object[] idChecklists { get; set; }
        public string[] idMembers { get; set; }
        public Label[] labels { get; set; }
        public string shortUrl { get; set; }
        public bool subscribed { get; set; }
        public string url { get; set; }
        public Cover cover { get; set; }
        public object[] attachments { get; set; }
        public object[] pluginData { get; set; }
        public customFieldItems[] customFieldItems { get; set; }
    }

    public class Descdata
    {
        public Emoji1 emoji { get; set; }
    }

    public class Emoji1
    {
    }

    public class Limits2
    {
        public Attachments1 attachments { get; set; }
        public Checklists1 checklists { get; set; }
        public Stickers1 stickers { get; set; }
    }

    public class Attachments1
    {
        public Percard3 perCard { get; set; }
    }

    public class Percard3
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Checklists1
    {
        public Percard4 perCard { get; set; }
    }

    public class Percard4
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Stickers1
    {
        public Percard5 perCard { get; set; }
    }

    public class Percard5
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Badges
    {
        public Attachmentsbytype attachmentsByType { get; set; }
        public bool location { get; set; }
        public int votes { get; set; }
        public bool viewingMemberVoted { get; set; }
        public bool subscribed { get; set; }
        public string fogbugz { get; set; }
        public int checkItems { get; set; }
        public int checkItemsChecked { get; set; }
        public int comments { get; set; }
        public int attachments { get; set; }
        public bool description { get; set; }
        public DateTime? due { get; set; }
        public bool dueComplete { get; set; }
    }

    public class Attachmentsbytype
    {
        public Trello trello { get; set; }
    }

    public class Trello
    {
        public int board { get; set; }
        public int card { get; set; }
    }

    public class Cover
    {
        public object idAttachment { get; set; }
        public object color { get; set; }
        public object idUploadedBackground { get; set; }
        public string size { get; set; }
        public string brightness { get; set; }
    }

    public class Label
    {
        public string id { get; set; }
        public string idBoard { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }

    public class Label1
    {
        public string id { get; set; }
        public string idBoard { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }
    
    public struct customFieldItems
    {
        public string id { get; set; }
        public CheckBox value { get; set; }
        public string idModel { get; set; }
        public string modelType { get; set; }
    }

    public class List1
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool closed { get; set; }
        public string idBoard { get; set; }
        public float pos { get; set; }
        public bool subscribed { get; set; }
        public object softLimit { get; set; }
        public Limits3 limits { get; set; }
        public object creationMethod { get; set; }
    }

    public class Limits3
    {
        public Cards1 cards { get; set; }
    }

    public class Cards1
    {
        public Openperlist1 openPerList { get; set; }
        public Totalperlist1 totalPerList { get; set; }
    }

    public class Openperlist1
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Totalperlist1
    {
        public string status { get; set; }
        public int disableAt { get; set; }
        public int warnAt { get; set; }
    }

    public class Member2
    {
        public string id { get; set; }
        public bool activityBlocked { get; set; }
        public string avatarHash { get; set; }
        public object avatarUrl { get; set; }
        public string bio { get; set; }
        public Biodata bioData { get; set; }
        public bool confirmed { get; set; }
        public string fullName { get; set; }
        public object idEnterprise { get; set; }
        public object[] idEnterprisesDeactivated { get; set; }
        public string idMemberReferrer { get; set; }
        public object[] idPremOrgsAdmin { get; set; }
        public string initials { get; set; }
        public string memberType { get; set; }
        public Nonpublic2 nonPublic { get; set; }
        public bool nonPublicAvailable { get; set; }
        public object[] products { get; set; }
        public string url { get; set; }
        public string username { get; set; }
        public string status { get; set; }
    }

    public class Biodata
    {
        public Emoji2 emoji { get; set; }
    }

    public class Emoji2
    {
    }

    public class Nonpublic2
    {
    }

    public class Membership
    {
        public string id { get; set; }
        public string idMember { get; set; }
        public string memberType { get; set; }
        public bool unconfirmed { get; set; }
        public bool deactivated { get; set; }
    }
}