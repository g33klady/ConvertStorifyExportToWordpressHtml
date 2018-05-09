using System;
using System.Collections.Generic;
using System.Text;

namespace StorifyPageConverter
{

    public class Rootobject
    {
        public Content content { get; set; }
        public int code { get; set; }
    }

    public class Content
    {
        public string sid { get; set; }
        public string title { get; set; }
        public string slug { get; set; }
        public string status { get; set; }
        public object template { get; set; }
        public int version { get; set; }
        public string permalink { get; set; }
        public string description { get; set; }
        public string thumbnail { get; set; }
        public Date date { get; set; }
        public bool _private { get; set; }
        public bool not_indexed { get; set; }
        public bool is_spam { get; set; }
        public object[] topics { get; set; }
        public object[] siteposts { get; set; }
        public Meta meta { get; set; }
        public Stats stats { get; set; }
        public bool modified { get; set; }
        public bool deleted { get; set; }
        public bool canEdit { get; set; }
        public Author author { get; set; }
        public object[] comments { get; set; }
        public int page { get; set; }
        public int per_page { get; set; }
        public int totalElements { get; set; }
        public Element[] elements { get; set; }
    }

    public class Date
    {
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public DateTime published { get; set; }
    }

    public class Meta
    {
        public Quoted[] quoted { get; set; }
        public string[] hashtags { get; set; }
        public Created_With created_with { get; set; }
    }

    public class Created_With
    {
        public string href { get; set; }
        public string appname { get; set; }
        public string name { get; set; }
    }

    public class Quoted
    {
        public string username { get; set; }
        public string name { get; set; }
        public string userid { get; set; }
        public string avatar { get; set; }
        public string source { get; set; }
        public object notified_at { get; set; }
    }

    public class Stats
    {
        public int popularity { get; set; }
        public int views { get; set; }
        public int likes { get; set; }
        public int comments { get; set; }
        public int elementComments { get; set; }
        public object[] embeds { get; set; }
        public Elements elements { get; set; }
    }

    public class Elements
    {
        public int text { get; set; }
        public int quote { get; set; }
        public int image { get; set; }
        public int video { get; set; }
        public int link { get; set; }
        public int other { get; set; }
    }

    public class Author
    {
        public string _id { get; set; }
        public string username { get; set; }
        public int _access { get; set; }
        public string name { get; set; }
        public string bio { get; set; }
        public string location { get; set; }
        public string website { get; set; }
        public string avatar { get; set; }
        public string permalink { get; set; }
        public Settings settings { get; set; }
        public string lang { get; set; }
        public Stats1 stats { get; set; }
        public Date1 date { get; set; }
        public Coverphoto coverPhoto { get; set; }
        public bool canFeatureStories { get; set; }
        public object[] featuredStories { get; set; }
        public string paid_plan { get; set; }
        public bool email_verified { get; set; }
        public Features_Enabled features_enabled { get; set; }
        public Agency agency { get; set; }
        public bool is_spam { get; set; }
        public bool photo_tos { get; set; }
        public bool canEdit { get; set; }
    }

    public class Settings
    {
        public string comments { get; set; }
        public bool facebook_autoshare { get; set; }
        public bool facebook_quoteimg { get; set; }
        public bool facebook_post { get; set; }
        public bool twitter_post { get; set; }
        public bool ban_notify { get; set; }
        public Options options { get; set; }
        public Notifications notifications { get; set; }
        public Style style { get; set; }
        public Style_Backup style_backup { get; set; }
        public object fb_page_id { get; set; }
        public object fb_page_link { get; set; }
        public object fb_page_name { get; set; }
        public Fb_Page fb_page { get; set; }
    }

    public class Options
    {
        public bool infinite_scroll { get; set; }
        public bool hide_stats { get; set; }
        public bool allow_embedding { get; set; }
        public bool comments { get; set; }
        public bool related_stories { get; set; }
        public bool ga { get; set; }
        public bool fb_page { get; set; }
    }

    public class Notifications
    {
        public bool newsletter { get; set; }
        public bool digest { get; set; }
        public bool likes { get; set; }
        public bool comments { get; set; }
        public bool follower { get; set; }
        public bool quoted { get; set; }
        public bool friend_quoted { get; set; }
        public bool autoshare { get; set; }
        public bool element_comment { get; set; }
        public bool element_like { get; set; }
        public bool story_comment { get; set; }
        public bool story_like { get; set; }
    }

    public class Style
    {
        public Fonts fonts { get; set; }
        public Colors colors { get; set; }
        public Typekit typekit { get; set; }
    }

    public class Fonts
    {
        public string title { get; set; }
        public string body { get; set; }
    }

    public class Colors
    {
        public string text { get; set; }
        public string link { get; set; }
        public string background { get; set; }
    }

    public class Typekit
    {
        public object[] fonts { get; set; }
    }

    public class Style_Backup
    {
    }

    public class Fb_Page
    {
    }

    public class Stats1
    {
        public int stories { get; set; }
        public int views { get; set; }
        public int embeds { get; set; }
        public int subscriptions { get; set; }
        public int subscribers { get; set; }
    }

    public class Date1
    {
        public DateTime last_seen { get; set; }
        public object featured { get; set; }
        public DateTime last_email { get; set; }
        public DateTime last_story { get; set; }
        public object trial_start { get; set; }
        public object trial_end { get; set; }
        public object spammed { get; set; }
        public object suspended { get; set; }
        public object muted { get; set; }
        public object upgraded { get; set; }
        public DateTime updated { get; set; }
        public DateTime last_digest { get; set; }
        public DateTime created { get; set; }
    }

    public class Coverphoto
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Features_Enabled
    {
        public bool custom_embed_style { get; set; }
        public bool private_stories { get; set; }
        public bool html_for_seo { get; set; }
        public bool no_advertising { get; set; }
        public bool business_options { get; set; }
        public bool headerless_embed { get; set; }
        public bool pdf { get; set; }
        public bool twitter_gnip { get; set; }
        public bool realtime_updates { get; set; }
        public int maxEditors { get; set; }
    }

    public class Agency
    {
        public bool isAgency { get; set; }
        public Agencyinfo agencyInfo { get; set; }
        public bool isCustomer { get; set; }
        public Customerinfo customerInfo { get; set; }
    }

    public class Agencyinfo
    {
        public int maxCustomersNum { get; set; }
        public object[] customers { get; set; }
    }

    public class Customerinfo
    {
        public bool approved { get; set; }
        public bool removalApproved { get; set; }
        public object agencyId { get; set; }
        public object agencyUsername { get; set; }
        public object approved_at { get; set; }
        public object paid_plan { get; set; }
        public Keys keys { get; set; }
    }

    public class Keys
    {
        public object approve { get; set; }
        public object remove { get; set; }
    }

    public class Element
    {
        public string id { get; set; }
        public string eid { get; set; }
        public string type { get; set; }
        public string permalink { get; set; }
        public DateTime posted_at { get; set; }
        public DateTime added_at { get; set; }
        public Data data { get; set; }
        public Source source { get; set; }
        public Attribution attribution { get; set; }
        public object[] comments { get; set; }
        public Stats2 stats { get; set; }
        public string via { get; set; }
        public Meta1 meta { get; set; }

        //public Element(string type, Data data)
        //{
        //    this.type = type;
        //    this.data = data;
        //}

        //public Element(string type, string permalink)
        //{
        //    this.type = type;
        //    this.permalink = permalink;
        //}
    }

    public class Data
    {
        public Oembed oembed { get; set; }
        public Link link { get; set; }
        public Image image { get; set; }
        public string text { get; set; }

        //public Data(string text)
        //{
        //    this.text = text;
        //}
    }

    public class Oembed
    {
        public string type { get; set; }
        public string html { get; set; }
        public string thumbnail_url { get; set; }
        public string title { get; set; }
        public string provider_url { get; set; }
        public string provider_name { get; set; }
        public string url { get; set; }
    }

    public class Link
    {
        public string rest_api_url { get; set; }
        public string oembed_url { get; set; }
        public string thumbnail { get; set; }
        public string description { get; set; }
        public string title { get; set; }
    }

    public class Image
    {
        public int thumbnail_height { get; set; }
        public int thumbnail_width { get; set; }
        public string thumbnail { get; set; }
        public string href { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string caption { get; set; }
        public string src { get; set; }
    }

    public class Source
    {
        public string tab { get; set; }
        public string href { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string userid { get; set; }
    }

    public class Attribution
    {
        public string location { get; set; }
        public string bio { get; set; }
        public bool verified { get; set; }
        public string thumbnail { get; set; }
        public string href { get; set; }
        public string username { get; set; }
        public string name { get; set; }
    }

    public class Stats2
    {
        public int likes { get; set; }
        public int comments { get; set; }
    }

    public class Meta1
    {
    }

}
