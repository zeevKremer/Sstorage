﻿
// Copyright 2012 Google Inc. All rights reserved.
(function () {

    var data = {
        "resource": {
            "version": "1",

            "macros": [{
                "function": "__e"
            }, {
                "function": "__cid"
            }],
            "tags": [{
                "function": "__rep",
                "once_per_event": true,
                "vtp_containerId": ["macro", 1],
                "tag_id": 1
            }],
            "predicates": [{
                "function": "_eq",
                "arg0": ["macro", 0],
                "arg1": "gtm.js"
            }],
            "rules": [
                [["if", 0], ["add", 0]]]
        },
        "runtime": []




    };
    /*
    
     Copyright The Closure Library Authors.
     SPDX-License-Identifier: Apache-2.0
    */
    var aa, ba = function (a) { var b = 0; return function () { return b < a.length ? { done: !1, value: a[b++] } : { done: !0 } } }, da = function (a) { var b = "undefined" != typeof Symbol && Symbol.iterator && a[Symbol.iterator]; return b ? b.call(a) : { next: ba(a) } }, ea = "function" == typeof Object.create ? Object.create : function (a) { var b = function () { }; b.prototype = a; return new b }, fa;
    if ("function" == typeof Object.setPrototypeOf) fa = Object.setPrototypeOf; else { var ia; a: { var ma = { a: !0 }, na = {}; try { na.__proto__ = ma; ia = na.a; break a } catch (a) { } ia = !1 } fa = ia ? function (a, b) { a.__proto__ = b; if (a.__proto__ !== b) throw new TypeError(a + " is not extensible"); return a } : null }
    var oa = fa, pa = function (a, b) { a.prototype = ea(b.prototype); a.prototype.constructor = a; if (oa) oa(a, b); else for (var c in b) if ("prototype" != c) if (Object.defineProperties) { var d = Object.getOwnPropertyDescriptor(b, c); d && Object.defineProperty(a, c, d) } else a[c] = b[c]; a.Mi = b.prototype }, qa = this || self, ta = function (a) { if (a && a != qa) return ra(a.document); null === sa && (sa = ra(qa.document)); return sa }, ua = /^[\w+/_-]+[=]{0,2}$/, sa = null, ra = function (a) {
        var b = a.querySelector && a.querySelector("script[nonce]"); if (b) {
            var c = b.nonce || b.getAttribute("nonce");
            if (c && ua.test(c)) return c
        } return ""
    }, va = function (a) { return a }; var xa = function () { }, ya = function (a) { return "function" == typeof a }, g = function (a) { return "string" == typeof a }, za = function (a) { return "number" == typeof a && !isNaN(a) }, Aa = function (a) { return "[object Array]" == Object.prototype.toString.call(Object(a)) }, m = function (a, b) { if (Array.prototype.indexOf) { var c = a.indexOf(b); return "number" == typeof c ? c : -1 } for (var d = 0; d < a.length; d++)if (a[d] === b) return d; return -1 }, Ba = function (a, b) { if (a && Aa(a)) for (var c = 0; c < a.length; c++)if (a[c] && b(a[c])) return a[c] }, Da = function (a, b) {
        if (!za(a) ||
            !za(b) || a > b) a = 0, b = 2147483647; return Math.floor(Math.random() * (b - a + 1) + a)
    }, Ga = function (a, b) { for (var c = new Ea, d = 0; d < a.length; d++)c.set(a[d], !0); for (var e = 0; e < b.length; e++)if (c.get(b[e])) return !0; return !1 }, Ia = function (a, b) { for (var c in a) Object.prototype.hasOwnProperty.call(a, c) && b(c, a[c]) }, Ja = function (a) { return !!a && ("[object Arguments]" == Object.prototype.toString.call(a) || Object.prototype.hasOwnProperty.call(a, "callee")) }, Ka = function (a) { return Math.round(Number(a)) || 0 }, Ma = function (a) {
        return "false" ==
            String(a).toLowerCase() ? !1 : !!a
    }, Na = function (a) { var b = []; if (Aa(a)) for (var c = 0; c < a.length; c++)b.push(String(a[c])); return b }, Oa = function (a) { return a ? a.replace(/^\s+|\s+$/g, "") : "" }, Pa = function () { return (new Date).getTime() }, Ea = function () { this.prefix = "gtm."; this.values = {} }; Ea.prototype.set = function (a, b) { this.values[this.prefix + a] = b }; Ea.prototype.get = function (a) { return this.values[this.prefix + a] };
    var Ra = function (a, b, c) { return a && a.hasOwnProperty(b) ? a[b] : c }, Sa = function (a) { var b = a; return function () { if (b) { var c = b; b = void 0; try { c() } catch (d) { } } } }, Ta = function (a, b) { for (var c in b) b.hasOwnProperty(c) && (a[c] = b[c]) }, Va = function (a) { for (var b in a) if (a.hasOwnProperty(b)) return !0; return !1 }, Wa = function (a, b) { for (var c = [], d = 0; d < a.length; d++)c.push(a[d]), c.push.apply(c, b[a[d]] || []); return c }, Za = function (a, b) { for (var c = {}, d = c, e = a.split("."), f = 0; f < e.length - 1; f++)d = d[e[f]] = {}; d[e[e.length - 1]] = b; return c }, $a = function (a) {
        var b =
            []; Ia(a, function (c, d) { 10 > c.length && d && b.push(c) }); return b.join(",")
    };/*
 jQuery v1.9.1 (c) 2005, 2012 jQuery Foundation, Inc. jquery.org/license. */
    var db = /\[object (Boolean|Number|String|Function|Array|Date|RegExp)\]/, eb = function (a) { if (null == a) return String(a); var b = db.exec(Object.prototype.toString.call(Object(a))); return b ? b[1].toLowerCase() : "object" }, fb = function (a, b) { return Object.prototype.hasOwnProperty.call(Object(a), b) }, gb = function (a) {
        if (!a || "object" != eb(a) || a.nodeType || a == a.window) return !1; try { if (a.constructor && !fb(a, "constructor") && !fb(a.constructor.prototype, "isPrototypeOf")) return !1 } catch (c) { return !1 } for (var b in a); return void 0 ===
            b || fb(a, b)
    }, C = function (a, b) { var c = b || ("array" == eb(a) ? [] : {}), d; for (d in a) if (fb(a, d)) { var e = a[d]; "array" == eb(e) ? ("array" != eb(c[d]) && (c[d] = []), c[d] = C(e, c[d])) : gb(e) ? (gb(c[d]) || (c[d] = {}), c[d] = C(e, c[d])) : c[d] = e } return c }; var hb = function (a) { if (void 0 === a || Aa(a) || gb(a)) return !0; switch (typeof a) { case "boolean": case "number": case "string": case "function": return !0 }return !1 }; var Ib;
    var Jb = [], Kb = [], Lb = [], Mb = [], Nb = [], Ob = {}, Pb, Qb, Rb, Tb = function (a, b) { var c = a["function"]; if (!c) throw Error("Error: No function name given for function call."); var d = Ob[c], e = {}, f; for (f in a) a.hasOwnProperty(f) && 0 === f.indexOf("vtp_") && (d && b && b.$e && b.$e(a[f]), e[void 0 !== d ? f : f.substr(4)] = a[f]); return void 0 !== d ? d(e) : Ib(c, e, b) }, Vb = function (a, b, c) { c = c || []; var d = {}, e; for (e in a) a.hasOwnProperty(e) && (d[e] = Ub(a[e], b, c)); return d }, Ub = function (a, b, c) {
        if (Aa(a)) {
            var d; switch (a[0]) {
                case "function_id": return a[1];
                case "list": d = []; for (var e = 1; e < a.length; e++)d.push(Ub(a[e], b, c)); return d; case "macro": var f = a[1]; if (c[f]) return; var h = Jb[f]; if (!h || b.yd(h)) return; c[f] = !0; try { var k = Vb(h, b, c); k.vtp_gtmEventId = b.id; d = Tb(k, b); Rb && (d = Rb.ah(d, k)) } catch (y) { b.qf && b.qf(y, Number(f)), d = !1 } c[f] = !1; return d; case "map": d = {}; for (var l = 1; l < a.length; l += 2)d[Ub(a[l], b, c)] = Ub(a[l + 1], b, c); return d; case "template": d = []; for (var p = !1, r = 1; r < a.length; r++) { var n = Ub(a[r], b, c); Qb && (p = p || n === Qb.bc); d.push(n) } return Qb && p ? Qb.eh(d) : d.join("");
                case "escape": d = Ub(a[1], b, c); if (Qb && Aa(a[1]) && "macro" === a[1][0] && Qb.Ah(a)) return Qb.Rh(d); d = String(d); for (var t = 2; t < a.length; t++)ib[a[t]] && (d = ib[a[t]](d)); return d; case "tag": var q = a[1]; if (!Mb[q]) throw Error("Unable to resolve tag reference " + q + "."); return d = { ef: a[2], index: q }; case "zb": var u = { arg0: a[2], arg1: a[3], ignore_case: a[5] }; u["function"] = a[1]; var v = Wb(u, b, c), x = !!a[4]; return x || 2 !== v ? x !== (1 === v) : null; default: throw Error("Attempting to expand unknown Value type: " + a[0] + ".");
            }
        } return a
    }, Wb = function (a,
        b, c) { try { return Pb(Vb(a, b, c)) } catch (d) { JSON.stringify(a) } return 2 }; var Xb = function () { var a = function (b) { return { toString: function () { return b } } }; return { Hf: a("consent"), Xd: a("convert_case_to"), Yd: a("convert_false_to"), Zd: a("convert_null_to"), $d: a("convert_true_to"), ae: a("convert_undefined_to"), mi: a("debug_mode_metadata"), Ma: a("function"), vg: a("instance_name"), wg: a("live_only"), xg: a("malware_disabled"), yg: a("metadata"), ri: a("original_activity_id"), si: a("original_vendor_template_id"), Ag: a("once_per_event"), Qe: a("once_per_load"), Ue: a("setup_tags"), Ve: a("tag_id"), We: a("teardown_tags") } }(); var Yb = null, ac = function (a) { function b(n) { for (var t = 0; t < n.length; t++)d[n[t]] = !0 } var c = [], d = []; Yb = Zb(a); for (var e = 0; e < Kb.length; e++) { var f = Kb[e], h = $b(f); if (h) { for (var k = f.add || [], l = 0; l < k.length; l++)c[k[l]] = !0; b(f.block || []) } else null === h && b(f.block || []) } for (var p = [], r = 0; r < Mb.length; r++)c[r] && !d[r] && (p[r] = !0); return p }, $b = function (a) {
            for (var b = a["if"] || [], c = 0; c < b.length; c++) { var d = Yb(b[c]); if (0 === d) return !1; if (2 === d) return null } for (var e = a.unless || [], f = 0; f < e.length; f++) {
                var h = Yb(e[f]); if (2 === h) return null;
                if (1 === h) return !1
            } return !0
        }, Zb = function (a) { var b = []; return function (c) { void 0 === b[c] && (b[c] = Wb(Lb[c], a)); return b[c] } }; var bc = { ah: function (a, b) { b[Xb.Xd] && "string" === typeof a && (a = 1 == b[Xb.Xd] ? a.toLowerCase() : a.toUpperCase()); b.hasOwnProperty(Xb.Zd) && null === a && (a = b[Xb.Zd]); b.hasOwnProperty(Xb.ae) && void 0 === a && (a = b[Xb.ae]); b.hasOwnProperty(Xb.$d) && !0 === a && (a = b[Xb.$d]); b.hasOwnProperty(Xb.Yd) && !1 === a && (a = b[Xb.Yd]); return a } };/*
 Copyright (c) 2014 Derek Brans, MIT license https://github.com/krux/postscribe/blob/master/LICENSE. Portions derived from simplehtmlparser, which is licensed under the Apache License, Version 2.0 */
    var E = {
        xb: "_ee", ld: "_syn", wi: "_uei", ed: "_eu", ui: "_pci", Tc: "event_callback", Xb: "event_timeout", ca: "gtag.config", Ia: "gtag.get", ka: "purchase", Wa: "refund", Ha: "begin_checkout", Ua: "add_to_cart", Va: "remove_from_cart", Rf: "view_cart", ee: "add_to_wishlist", xa: "view_item", de: "view_promotion", ce: "select_promotion", Oc: "select_item", Ub: "view_item_list", be: "add_payment_info", Qf: "add_shipping_info", Aa: "value_key", za: "value_callback", da: "allow_ad_personalization_signals", ad: "restricted_data_processing", nb: "allow_google_signals",
        fa: "cookie_expires", qb: "cookie_update", ub: "session_duration", ma: "user_properties", La: "transport_url", M: "ads_data_redaction", B: "ad_storage", I: "analytics_storage", If: "region", Jf: "wait_for_update"
    };
    E.Pc = "page_view", E.fe = "user_engagement", E.Lf = "app_remove", E.Mf = "app_store_refund", E.Nf = "app_store_subscription_cancel", E.Of = "app_store_subscription_convert", E.Pf = "app_store_subscription_renew", E.Sf = "first_open", E.Tf = "first_visit", E.Uf = "in_app_purchase", E.Vf = "session_start", E.Wf = "allow_custom_scripts", E.Xf = "allow_display_features", E.Qc = "allow_enhanced_conversions", E.xe = "enhanced_conversions", E.Xa = "client_id", E.V = "cookie_domain", E.Wb = "cookie_name", E.Ja = "cookie_path", E.la = "cookie_flags", E.ya = "currency",
        E.qe = "custom_map", E.Xc = "groups", E.Ya = "language", E.oe = "country", E.ni = "non_interaction", E.sb = "page_location", E.Ba = "page_referrer", E.$c = "page_title", E.tb = "send_page_view", E.Ka = "send_to", E.bd = "session_engaged", E.$b = "session_id", E.cd = "session_number", E.pg = "tracking_id", E.ia = "linker", E.Ca = "url_passthrough", E.Za = "accept_incoming", E.H = "domains", E.ab = "url_position", E.$a = "decorate_forms", E.Ce = "phone_conversion_number", E.Ae = "phone_conversion_callback", E.Be = "phone_conversion_css_class", E.De = "phone_conversion_options",
        E.kg = "phone_conversion_ids", E.jg = "phone_conversion_country_code", E.he = "aw_remarketing", E.ie = "aw_remarketing_only", E.Vb = "gclid", E.Da = "value", E.lg = "quantity", E.ag = "affiliation", E.we = "tax", E.ve = "shipping", E.Sc = "list_name", E.ue = "checkout_step", E.te = "checkout_option", E.bg = "coupon", E.cg = "promotions", E.vb = "transaction_id", E.wb = "user_id", E.mg = "retoken", E.pb = "conversion_linker", E.ob = "conversion_cookie_prefix", E.X = "cookie_prefix", E.U = "items", E.ne = "aw_merchant_id", E.ke = "aw_feed_country", E.me = "aw_feed_language",
        E.je = "discount", E.se = "disable_merchant_reported_purchases", E.ze = "new_customer", E.pe = "customer_lifetime_value", E.$f = "dc_natural_search", E.Zf = "dc_custom_params", E.qg = "trip_type", E.ig = "passengers", E.gg = "method", E.og = "search_term", E.Yf = "content_type", E.hg = "optimize_id", E.dg = "experiments", E.rb = "google_signals", E.Wc = "google_tld", E.ac = "update", E.Vc = "firebase_id", E.Yb = "ga_restrict_domain", E.Uc = "event_settings", E.Rc = "dynamic_event_settings", E.ng = "screen_name", E.fg = "_x_19", E.eg = "_x_20", E.Zc = "internal_traffic_results",
        E.Ee = "traffic_type", E.Zb = "referral_exclusion_definition", E.Yc = "ignore_referrer", E.dd = "delivery_postal_code", E.ye = "estimated_delivery_date", E.rg = [E.da, E.Qc, E.nb, E.U, E.ad, E.V, E.fa, E.la, E.Wb, E.Ja, E.X, E.qb, E.qe, E.Rc, E.Tc, E.Uc, E.Xb, E.Yb, E.rb, E.Wc, E.Xc, E.Zc, E.ia, E.Zb, E.Ka, E.tb, E.ub, E.La, E.ac, E.ma, E.dd, E.ed], E.Fe = [E.sb, E.Ba, E.$c, E.Ya, E.ng, E.wb, E.Vc], E.ug = [E.Lf, E.Mf, E.Nf, E.Of, E.Pf, E.Sf, E.Tf, E.Uf, E.Vf, E.fe], E.Wd = [E.da, E.Qc, E.he, E.ie, E.je, E.ke, E.me, E.U, E.ne, E.ob, E.pb, E.V, E.fa, E.la, E.X, E.ya, E.pe, E.se, E.xe, E.ye,
        E.Vc, E.Ya, E.ze, E.sb, E.Ba, E.Ae, E.Be, E.Ce, E.De, E.ad, E.tb, E.Ka, E.dd, E.vb, E.La, E.ac, E.Ca, E.wb, E.Da]; E.He = [E.ka, E.Wa, E.Ha, E.Ua, E.Va, E.Rf, E.ee, E.xa, E.de, E.ce, E.Ub, E.Oc, E.be, E.Qf]; E.Ge = [E.da, E.nb, E.qb]; E.Ie = [E.fa, E.Xb, E.ub]; var Ac = {}, Bc = function (a, b) { Ac[a] = Ac[a] || []; Ac[a][b] = !0 }, Cc = function (a) { for (var b = [], c = Ac[a] || [], d = 0; d < c.length; d++)c[d] && (b[Math.floor(d / 6)] ^= 1 << d % 6); for (var e = 0; e < b.length; e++)b[e] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_".charAt(b[e] || 0); return b.join("") }; var Dc = function (a) { Bc("GTM", a) }; var Fc = function (a, b) { var c = function () { }; c.prototype = a.prototype; var d = new c; a.apply(d, Array.prototype.slice.call(arguments, 1)); return d }, Gc = function (a) { var b = a; return function () { if (b) { var c = b; b = null; c() } } }; var Hc, Ic = function () { if (void 0 === Hc) { var a = null, b = qa.trustedTypes; if (b && b.createPolicy) { try { a = b.createPolicy("goog#html", { createHTML: va, createScript: va, createScriptURL: va }) } catch (c) { qa.console && qa.console.error(c.message) } Hc = a } else Hc = a } return Hc }; var Oc = function (a, b) { this.m = b === Nc ? a : "" }; Oc.prototype.toString = function () { return this.m + "" }; var Nc = {}; var Pc = /^(?:(?:https?|mailto|ftp):|[^:/?#]*(?:[/?#]|$))/i; var Qc; a: { var Rc = qa.navigator; if (Rc) { var Sc = Rc.userAgent; if (Sc) { Qc = Sc; break a } } Qc = "" } var Tc = function (a) { return -1 != Qc.indexOf(a) }; var Vc = function (a, b, c) { this.m = c === Uc ? a : "" }; Vc.prototype.toString = function () { return this.m.toString() }; var Wc = function (a) { return a instanceof Vc && a.constructor === Vc ? a.m : "type_error:SafeHtml" }, Uc = {}, Xc = new Vc(qa.trustedTypes && qa.trustedTypes.emptyHTML || "", 0, Uc); var Yc = function (a) { var b = !1, c; return function () { b || (c = a(), b = !0); return c } }(function () { var a = document.createElement("div"), b = document.createElement("div"); b.appendChild(document.createElement("div")); a.appendChild(b); var c = a.firstChild.firstChild; a.innerHTML = Wc(Xc); return !c.parentElement }), Zc = function (a, b) { if (Yc()) for (; a.lastChild;)a.removeChild(a.lastChild); a.innerHTML = Wc(b) }; var $c = function (a) { var b = Ic(), c = b ? b.createHTML(a) : a; return new Vc(c, null, Uc) }; var G = window, H = document, ad = navigator, bd = H.currentScript && H.currentScript.src, cd = function (a, b) { var c = G[a]; G[a] = void 0 === c ? b : c; return G[a] }, dd = function (a, b) { b && (a.addEventListener ? a.onload = b : a.onreadystatechange = function () { a.readyState in { loaded: 1, complete: 1 } && (a.onreadystatechange = null, b()) }) }, jd = function (a, b, c) {
            var d = H.createElement("script"); d.type = "text/javascript"; d.async = !0; var e, f = Ic(), h = f ? f.createScriptURL(a) : a; e = new Oc(h, Nc); d.src = e instanceof Oc && e.constructor === Oc ? e.m : "type_error:TrustedResourceUrl";
            var k = ta(d.ownerDocument && d.ownerDocument.defaultView); k && d.setAttribute("nonce", k); dd(d, b); c && (d.onerror = c); var l = ta(); l && d.setAttribute("nonce", l); var p = H.getElementsByTagName("script")[0] || H.body || H.head; p.parentNode.insertBefore(d, p); return d
        }, kd = function () { if (bd) { var a = bd.toLowerCase(); if (0 === a.indexOf("https://")) return 2; if (0 === a.indexOf("http://")) return 3 } return 1 }, ld = function (a, b) {
            var c = H.createElement("iframe"); c.height = "0"; c.width = "0"; c.style.display = "none"; c.style.visibility = "hidden";
            var d = H.body && H.body.lastChild || H.body || H.head; d.parentNode.insertBefore(c, d); dd(c, b); void 0 !== a && (c.src = a); return c
        }, md = function (a, b, c) { var d = new Image(1, 1); d.onload = function () { d.onload = null; b && b() }; d.onerror = function () { d.onerror = null; c && c() }; d.src = a; return d }, nd = function (a, b, c, d) { a.addEventListener ? a.addEventListener(b, c, !!d) : a.attachEvent && a.attachEvent("on" + b, c) }, od = function (a, b, c) { a.removeEventListener ? a.removeEventListener(b, c, !1) : a.detachEvent && a.detachEvent("on" + b, c) }, I = function (a) {
            G.setTimeout(a,
                0)
        }, pd = function (a, b) { return a && b && a.attributes && a.attributes[b] ? a.attributes[b].value : null }, qd = function (a) { var b = a.innerText || a.textContent || ""; b && " " != b && (b = b.replace(/^[\s\xa0]+|[\s\xa0]+$/g, "")); b && (b = b.replace(/(\xa0+|\s{2,}|\n|\r\t)/g, " ")); return b }, rd = function (a) { var b = H.createElement("div"), c = $c("A<div>" + a + "</div>"); Zc(b, c); b = b.lastChild; for (var d = []; b.firstChild;)d.push(b.removeChild(b.firstChild)); return d }, sd = function (a, b, c) {
            c = c || 100; for (var d = {}, e = 0; e < b.length; e++)d[b[e]] = !0; for (var f =
                a, h = 0; f && h <= c; h++) { if (d[String(f.tagName).toLowerCase()]) return f; f = f.parentElement } return null
        }, td = function (a) { ad.sendBeacon && ad.sendBeacon(a) || md(a) }, ud = function (a, b) { var c = a[b]; c && "string" === typeof c.animVal && (c = c.animVal); return c }; var vd = {}, wd = function () { return void 0 == vd.gtag_cs_api ? !1 : vd.gtag_cs_api }; var xd = []; function yd() { var a = cd("google_tag_data", {}); a.ics || (a.ics = { entries: {}, set: zd, update: Ad, addListener: Bd, notifyListeners: Cd, active: !1, usedDefault: !1 }); return a.ics }
    function zd(a, b, c, d, e, f) { var h = yd(); h.active = !0; h.usedDefault = !0; if (void 0 != b) { var k = h.entries, l = k[a] || {}, p = l.region, r = c && g(c) ? c.toUpperCase() : void 0; d = d.toUpperCase(); e = e.toUpperCase(); if (r === e || (r === d ? p !== e : !r && !p)) { var n = !!(f && 0 < f && void 0 === l.update), t = { region: r, initial: "granted" === b, update: l.update, quiet: n }; k[a] = t; n && G.setTimeout(function () { k[a] === t && t.quiet && (t.quiet = !1, Dd(a), Cd(), Bc("TAGGING", 2)) }, f) } } }
    function Ad(a, b) { var c = yd(); c.active = !0; if (void 0 != b) { var d = Ed(a), e = c.entries, f = e[a] = e[a] || {}; f.update = "granted" === b; var h = Ed(a); f.quiet ? (f.quiet = !1, Dd(a)) : h !== d && Dd(a) } } function Bd(a, b) { xd.push({ bf: a, nh: b }) } function Dd(a) { for (var b = 0; b < xd.length; ++b) { var c = xd[b]; Aa(c.bf) && -1 !== c.bf.indexOf(a) && (c.uf = !0) } } function Cd(a) { for (var b = 0; b < xd.length; ++b) { var c = xd[b]; if (c.uf) { c.uf = !1; try { c.nh({ af: a }) } catch (d) { } } } }
    var Ed = function (a) { var b = yd().entries[a] || {}; return void 0 !== b.update ? b.update : void 0 !== b.initial ? b.initial : void 0 }, Fd = function (a) { return (yd().entries[a] || {}).initial }, Gd = function (a) { return !(yd().entries[a] || {}).quiet }, Hd = function () { return wd() ? yd().active : !1 }, Id = function (a, b) { yd().addListener(a, b) }, Jd = function (a, b) { function c() { for (var e = 0; e < b.length; e++)if (!Gd(b[e])) return !0; return !1 } if (c()) { var d = !1; Id(b, function (e) { d || c() || (d = !0, a(e)) }) } else a({}) }, Kd = function (a, b) {
        if (!1 === Ed(b)) {
            var c = !1; Id([b],
                function (d) { !c && Ed(b) && (a(d), c = !0) })
        }
    }; function Ld(a) { for (var b = [], c = 0; c < Md.length; c++) { var d = a(Md[c]); b[c] = !0 === d ? "1" : !1 === d ? "0" : "-" } return b.join("") }
    var Md = [E.B, E.I], Nd = function (a) { var b = a[E.If]; b && Dc(40); var c = a[E.Jf]; c && Dc(41); for (var d = Aa(b) ? b : [b], e = 0; e < d.length; ++e)for (var f = 0; f < Md.length; f++) { var h = Md[f], k = a[Md[f]], l = d[e]; yd().set(h, k, l, "IL", "IL-TA", c) } }, Od = function (a, b) { for (var c = 0; c < Md.length; c++) { var d = Md[c], e = a[Md[c]]; yd().update(d, e) } yd().notifyListeners(b) }, Pd = function (a) { var b = Ed(a); return void 0 != b ? b : !0 }, Qd = function () { return "G1" + Ld(Ed) }, Rd = function (a, b) { Jd(a, b) }; var Td = function (a) { return Sd ? H.querySelectorAll(a) : null }, Ud = function (a, b) {
        if (!Sd) return null; if (Element.prototype.closest) try { return a.closest(b) } catch (e) { return null } var c = Element.prototype.matches || Element.prototype.webkitMatchesSelector || Element.prototype.mozMatchesSelector || Element.prototype.msMatchesSelector || Element.prototype.oMatchesSelector, d = a; if (!H.documentElement.contains(d)) return null; do { try { if (c.call(d, b)) return d } catch (e) { break } d = d.parentElement || d.parentNode } while (null !== d && 1 === d.nodeType);
        return null
    }, Vd = !1; if (H.querySelectorAll) try { var Wd = H.querySelectorAll(":root"); Wd && 1 == Wd.length && Wd[0] == H.documentElement && (Vd = !0) } catch (a) { } var Sd = Vd; var Xd = function (a) {
        if (H.hidden) return !0; var b = a.getBoundingClientRect(); if (b.top == b.bottom || b.left == b.right || !G.getComputedStyle) return !0; var c = G.getComputedStyle(a, null); if ("hidden" === c.visibility) return !0; for (var d = a, e = c; d;) {
            if ("none" === e.display) return !0; var f = e.opacity, h = e.filter; if (h) { var k = h.indexOf("opacity("); 0 <= k && (h = h.substring(k + 8, h.indexOf(")", k)), "%" == h.charAt(h.length - 1) && (h = h.substring(0, h.length - 1)), f = Math.min(h, f)) } if (void 0 !== f && 0 >= f) return !0; (d = d.parentElement) && (e = G.getComputedStyle(d,
                null))
        } return !1
    }; var fe = /:[0-9]+$/, ge = function (a, b, c) { for (var d = a.split("&"), e = 0; e < d.length; e++) { var f = d[e].split("="); if (decodeURIComponent(f[0]).replace(/\+/g, " ") === b) { var h = f.slice(1).join("="); return c ? h : decodeURIComponent(h).replace(/\+/g, " ") } } }, je = function (a, b, c, d, e) {
        b && (b = String(b).toLowerCase()); if ("protocol" === b || "port" === b) a.protocol = he(a.protocol) || he(G.location.protocol); "port" === b ? a.port = String(Number(a.hostname ? a.port : G.location.port) || ("http" == a.protocol ? 80 : "https" == a.protocol ? 443 : "")) : "host" === b &&
            (a.hostname = (a.hostname || G.location.hostname).replace(fe, "").toLowerCase()); return ie(a, b, c, d, e)
    }, ie = function (a, b, c, d, e) {
        var f, h = he(a.protocol); b && (b = String(b).toLowerCase()); switch (b) {
            case "url_no_fragment": f = ke(a); break; case "protocol": f = h; break; case "host": f = a.hostname.replace(fe, "").toLowerCase(); if (c) { var k = /^www\d*\./.exec(f); k && k[0] && (f = f.substr(k[0].length)) } break; case "port": f = String(Number(a.port) || ("http" == h ? 80 : "https" == h ? 443 : "")); break; case "path": a.pathname || a.hostname || Bc("TAGGING",
                1); f = "/" == a.pathname.substr(0, 1) ? a.pathname : "/" + a.pathname; var l = f.split("/"); 0 <= m(d || [], l[l.length - 1]) && (l[l.length - 1] = ""); f = l.join("/"); break; case "query": f = a.search.replace("?", ""); e && (f = ge(f, e, void 0)); break; case "extension": var p = a.pathname.split("."); f = 1 < p.length ? p[p.length - 1] : ""; f = f.split("/")[0]; break; case "fragment": f = a.hash.replace("#", ""); break; default: f = a && a.href
        }return f
    }, he = function (a) { return a ? a.replace(":", "").toLowerCase() : "" }, ke = function (a) {
        var b = ""; if (a && a.href) {
            var c = a.href.indexOf("#");
            b = 0 > c ? a.href : a.href.substr(0, c)
        } return b
    }, le = function (a) { var b = H.createElement("a"); a && (b.href = a); var c = b.pathname; "/" !== c[0] && (a || Bc("TAGGING", 1), c = "/" + c); var d = b.hostname.replace(fe, ""); return { href: b.href, protocol: b.protocol, host: b.host, hostname: d, pathname: c, search: b.search, hash: b.hash, port: b.port } }, me = function (a) {
        function b(p) { var r = p.split("=")[0]; return 0 > d.indexOf(r) ? p : r + "=0" } function c(p) { return p.split("&").map(b).filter(function (r) { return void 0 != r }).join("&") } var d = "gclid dclid gclaw gcldc gclgp gclha gclgf _gl".split(" "),
            e = le(a), f = a.split(/[?#]/)[0], h = e.search, k = e.hash; "?" === h[0] && (h = h.substring(1)); "#" === k[0] && (k = k.substring(1)); h = c(h); k = c(k); "" !== h && (h = "?" + h); "" !== k && (k = "#" + k); var l = "" + f + h + k; "/" === l[l.length - 1] && (l = l.substring(0, l.length - 1)); return l
    }; var ne = new RegExp(/[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}/i), oe = new RegExp(/support|noreply/i), pe = ["SCRIPT", "IMG", "SVG", "PATH", "BR"], qe = ["BR"]; function re(a) { var b; if (a === H.body) b = "body"; else { var c; if (a.id) c = "#" + a.id; else { var d; if (a.parentElement) { var e; a: { var f = a.parentElement; if (f) { for (var h = 0; h < f.childElementCount; h++)if (f.children[h] === a) { e = h + 1; break a } e = -1 } else e = 1 } d = re(a.parentElement) + ">:nth-child(" + e + ")" } else d = ""; c = d } b = c } return b }
    var ue = function () {
        var a = !0; var b = a, c; var d = [], e = H.body; if (e) { for (var f = e.querySelectorAll("*"), h = 0; h < f.length && 1E4 > h; h++) { var k = f[h]; if (!(0 <= pe.indexOf(k.tagName.toUpperCase()))) { for (var l = !1, p = 0; p < k.childElementCount && 1E4 > p; p++)if (!(0 <= qe.indexOf(k.children[p].tagName.toUpperCase()))) { l = !0; break } l || d.push(k) } } c = { elements: d, status: 1E4 < f.length ? "2" : "1" } } else c =
            { elements: d, status: "4" }; for (var r = c, n = r.elements, t = [], q = 0; q < n.length; q++) { var u = n[q], v = u.textContent; u.value && (v = u.value); if (v) { var x = v.match(ne); if (x) { var y = x[0], w; if (G.location) { var z = ie(G.location, "host", !0); w = 0 <= y.toLowerCase().indexOf(z) } else w = !1; w || t.push({ element: u, Mc: y }) } } } var A; for (var B = [], D = 10 < t.length ? "3" : r.status, F = 0; F < t.length &&
                10 > F; F++) { var K = t[F].element, P = t[F].Mc, S = !1; B.push({ Mc: P, querySelector: re(K), tagName: K.tagName, isVisible: !Xd(K), type: 1, zc: !!S }) } return { elements: B, status: D }
    }; var Ie = {}, M = null, Je = Math.random(); Ie.D = "UA-23581568-13"; Ie.ic = "1k0"; Ie.oi = ""; Ie.Kf = "ChEIgLDpgAYQ5MrikdX3zPSnARInAD7x9mbWyhVGNCjFuaRJTsxAaF9IkecRCNnhivs1ZTLQ9aO7oqJyGgJBww\x3d\x3d"; var Ke = { __cl: !0, __ecl: !0, __ehl: !0, __evl: !0, __fal: !0, __fil: !0, __fsl: !0, __hl: !0, __jel: !0, __lcl: !0, __sdl: !0, __tl: !0, __ytl: !0 }, Le = { __paused: !0, __tg: !0 }, Me; for (Me in Ke) Ke.hasOwnProperty(Me) && (Le[Me] = !0); var Ne = "www.googletagmanager.com/gtm.js"; Ne = "www.googletagmanager.com/gtag/js";
    var Oe = Ne, Pe = Ma(""), Qe = null, Re = null, Se = "//www.googletagmanager.com/a?id=" + Ie.D + "&cv=1", Te = {}, Ue = {}, Ve = function () { var a = M.sequence || 1; M.sequence = a + 1; return a }; var We = {}, Xe = new Ea, Ye = {}, Ze = {}, bf = { name: "dataLayer", set: function (a, b) { C(Za(a, b), Ye); $e() }, get: function (a) { return af(a, 2) }, reset: function () { Xe = new Ea; Ye = {}; $e() } }, af = function (a, b) { return 2 != b ? Xe.get(a) : cf(a) }, cf = function (a) { var b, c = a.split("."); b = b || []; for (var d = Ye, e = 0; e < c.length; e++) { if (null === d) return !1; if (void 0 === d) break; d = d[c[e]]; if (-1 !== m(b, d)) return } return d }, df = function (a, b) { Ze.hasOwnProperty(a) || (Xe.set(a, b), C(Za(a, b), Ye), $e()) }, $e = function (a) {
        Ia(Ze, function (b, c) {
            Xe.set(b, c); C(Za(b, void 0),
                Ye); C(Za(b, c), Ye); a && delete Ze[b]
        })
    }, ef = function (a, b, c) { We[a] = We[a] || {}; var d = 1 !== c ? cf(b) : Xe.get(b); "array" === eb(d) || "object" === eb(d) ? We[a][b] = C(d) : We[a][b] = d }, ff = function (a, b) { if (We[a]) return We[a][b] }, gf = function (a, b) { We[a] && delete We[a][b] }; var kf = {}, lf = function (a, b) { if (G._gtmexpgrp && G._gtmexpgrp.hasOwnProperty(a)) return G._gtmexpgrp[a]; void 0 === kf[a] && (kf[a] = Math.floor(Math.random() * b)); return kf[a] }; var nf = function (a) { var b = 1, c, d, e; if (a) for (b = 0, d = a.length - 1; 0 <= d; d--)e = a.charCodeAt(d), b = (b << 6 & 268435455) + e + (e << 14), c = b & 266338304, b = 0 != c ? b ^ c >> 21 : b; return b }; function of(a, b, c) { for (var d = [], e = b.split(";"), f = 0; f < e.length; f++) { var h = e[f].split("="), k = h[0].replace(/^\s*|\s*$/g, ""); if (k && k == a) { var l = h.slice(1).join("=").replace(/^\s*|\s*$/g, ""); l && c && (l = decodeURIComponent(l)); d.push(l) } } return d }; var qf = function (a, b, c, d) { return pf(d) ? of(a, String(b || document.cookie), c) : [] }, tf = function (a, b, c, d, e) { if (pf(e)) { var f = rf(a, d, e); if (1 === f.length) return f[0].id; if (0 !== f.length) { f = sf(f, function (h) { return h.sc }, b); if (1 === f.length) return f[0].id; f = sf(f, function (h) { return h.Lb }, c); return f[0] ? f[0].id : void 0 } } }; function uf(a, b, c, d) { var e = document.cookie; document.cookie = a; var f = document.cookie; return e != f || void 0 != c && 0 <= qf(b, f, !1, d).indexOf(c) }
    var yf = function (a, b, c) {
        function d(q, u, v) { if (null == v) return delete h[u], q; h[u] = v; return q + "; " + u + "=" + v } function e(q, u) { if (null == u) return delete h[u], q; h[u] = !0; return q + "; " + u } if (!pf(c.sa)) return 2; var f; void 0 == b ? f = a + "=deleted; expires=" + (new Date(0)).toUTCString() : (c.encode && (b = encodeURIComponent(b)), b = vf(b), f = a + "=" + b); var h = {}; f = d(f, "path", c.path); var k; c.expires instanceof Date ? k = c.expires.toUTCString() : null != c.expires && (k = "" + c.expires); f = d(f, "expires", k); f = d(f, "max-age", c.Fi); f = d(f, "samesite",
            c.Ji); c.Ki && (f = e(f, "secure")); var l = c.domain; if ("auto" === l) { for (var p = wf(), r = 0; r < p.length; ++r) { var n = "none" !== p[r] ? p[r] : void 0, t = d(f, "domain", n); t = e(t, c.flags); if (!xf(n, c.path) && uf(t, a, b, c.sa)) return 0 } return 1 } l && "none" !== l && (f = d(f, "domain", l)); f = e(f, c.flags); return xf(l, c.path) ? 1 : uf(f, a, b, c.sa) ? 0 : 1
    }, zf = function (a, b, c) { null == c.path && (c.path = "/"); c.domain || (c.domain = "auto"); return yf(a, b, c) };
    function sf(a, b, c) { for (var d = [], e = [], f, h = 0; h < a.length; h++) { var k = a[h], l = b(k); l === c ? d.push(k) : void 0 === f || l < f ? (e = [k], f = l) : l === f && e.push(k) } return 0 < d.length ? d : e } function rf(a, b, c) { for (var d = [], e = qf(a, void 0, void 0, c), f = 0; f < e.length; f++) { var h = e[f].split("."), k = h.shift(); if (!b || -1 !== b.indexOf(k)) { var l = h.shift(); l && (l = l.split("-"), d.push({ id: h.join("."), sc: 1 * l[0] || 1, Lb: 1 * l[1] || 1 })) } } return d }
    var vf = function (a) { a && 1200 < a.length && (a = a.substring(0, 1200)); return a }, Af = /^(www\.)?google(\.com?)?(\.[a-z]{2})?$/, Bf = /(^|\.)doubleclick\.net$/i, xf = function (a, b) { return Bf.test(document.location.hostname) || "/" === b && Af.test(a) }, wf = function () {
        var a = [], b = document.location.hostname.split("."); if (4 === b.length) { var c = b[b.length - 1]; if (parseInt(c, 10).toString() === c) return ["none"] } for (var d = b.length - 2; 0 <= d; d--)a.push(b.slice(d).join(".")); var e = document.location.hostname; Bf.test(e) || Af.test(e) || a.push("none");
        return a
    }, pf = function (a) { if (!wd() || !a || !Hd()) return !0; if (!Gd(a)) return !1; var b = Ed(a); return null == b ? !0 : !!b }; var Cf = function () { for (var a = ad.userAgent + (H.cookie || "") + (H.referrer || ""), b = a.length, c = G.history.length; 0 < c;)a += c-- ^ b++; return [Math.round(2147483647 * Math.random()) ^ nf(a) & 2147483647, Math.round(Pa() / 1E3)].join(".") }, Ff = function (a, b, c, d, e) { var f = Df(b); return tf(a, f, Ef(c), d, e) }, Gf = function (a, b, c, d) { var e = "" + Df(c), f = Ef(d); 1 < f && (e += "-" + f); return [b, e, a].join(".") }, Df = function (a) { if (!a) return 1; a = 0 === a.indexOf(".") ? a.substr(1) : a; return a.split(".").length }, Ef = function (a) {
        if (!a || "/" === a) return 1; "/" !== a[0] &&
            (a = "/" + a); "/" !== a[a.length - 1] && (a += "/"); return a.split("/").length - 1
    }; function Hf(a, b, c) { var d, e = a.Kb; null == e && (e = 7776E3); 0 !== e && (d = new Date((b || Pa()) + 1E3 * e)); return { path: a.path, domain: a.domain, flags: a.flags, encode: !!c, expires: d } }; var If = ["1"], Jf = {}, Mf = function (a) { var b = Kf(a.prefix), c = Jf[b]; c && Lf(b, c, a) }, Of = function (a) { var b = Kf(a.prefix); if (!Jf[b] && !Nf(b, a.path, a.domain)) { var c = Cf(); Lf(b, c, a); var d = cd("google_tag_data", {}); d._gcl_au ? Bc("GTM", 57) : d._gcl_au = c; Nf(b, a.path, a.domain) } }; function Lf(a, b, c) { var d = Gf(b, "1", c.domain, c.path), e = Hf(c); e.sa = "ad_storage"; zf(a, d, e) } function Nf(a, b, c) { var d = Ff(a, b, c, If, "ad_storage"); d && (Jf[a] = d); return d } function Kf(a) { return (a || "_gcl") + "_au" }; function Pf() { for (var a = Qf, b = {}, c = 0; c < a.length; ++c)b[a[c]] = c; return b } function Rf() { var a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; a += a.toLowerCase() + "0123456789-_"; return a + "." } var Qf, Sf;
    function Tf(a) { function b(l) { for (; d < a.length;) { var p = a.charAt(d++), r = Sf[p]; if (null != r) return r; if (!/^[\s\xa0]*$/.test(p)) throw Error("Unknown base64 encoding at char: " + p); } return l } Qf = Qf || Rf(); Sf = Sf || Pf(); for (var c = "", d = 0; ;) { var e = b(-1), f = b(0), h = b(64), k = b(64); if (64 === k && -1 === e) return c; c += String.fromCharCode(e << 2 | f >> 4); 64 != h && (c += String.fromCharCode(f << 4 & 240 | h >> 2), 64 != k && (c += String.fromCharCode(h << 6 & 192 | k))) } }; var Uf; var Yf = function () { var a = Vf, b = Wf, c = Xf(), d = function (h) { a(h.target || h.srcElement || {}) }, e = function (h) { b(h.target || h.srcElement || {}) }; if (!c.init) { nd(H, "mousedown", d); nd(H, "keyup", d); nd(H, "submit", e); var f = HTMLFormElement.prototype.submit; HTMLFormElement.prototype.submit = function () { b(this); f.call(this) }; c.init = !0 } }, Zf = function (a, b, c, d, e) { var f = { callback: a, domains: b, fragment: 2 === c, placement: c, forms: d, sameHost: e }; Xf().decorators.push(f) }, $f = function (a, b, c) {
        for (var d = Xf().decorators, e = {}, f = 0; f < d.length; ++f) {
            var h =
                d[f], k; if (k = !c || h.forms) a: { var l = h.domains, p = a, r = !!h.sameHost; if (l && (r || p !== H.location.hostname)) for (var n = 0; n < l.length; n++)if (l[n] instanceof RegExp) { if (l[n].test(p)) { k = !0; break a } } else if (0 <= p.indexOf(l[n]) || r && 0 <= l[n].indexOf(p)) { k = !0; break a } k = !1 } if (k) { var t = h.placement; void 0 == t && (t = h.fragment ? 2 : 1); t === b && Ta(e, h.callback()) }
        } return e
    }, Xf = function () { var a = cd("google_tag_data", {}), b = a.gl; b && b.decorators || (b = { decorators: [] }, a.gl = b); return b }; var ag = /(.*?)\*(.*?)\*(.*)/, bg = /^https?:\/\/([^\/]*?)\.?cdn\.ampproject\.org\/?(.*)/, cg = /^(?:www\.|m\.|amp\.)+/, dg = /([^?#]+)(\?[^#]*)?(#.*)?/; function eg(a) { return new RegExp("(.*?)(^|&)" + a + "=([^&]*)&?(.*)") }
    var gg = function (a) {
        var b = [], c; for (c in a) if (a.hasOwnProperty(c)) { var d = a[c]; if (void 0 !== d && d === d && null !== d && "[object Object]" !== d.toString()) { b.push(c); var e = b, f = e.push, h, k = String(d); Qf = Qf || Rf(); Sf = Sf || Pf(); for (var l = [], p = 0; p < k.length; p += 3) { var r = p + 1 < k.length, n = p + 2 < k.length, t = k.charCodeAt(p), q = r ? k.charCodeAt(p + 1) : 0, u = n ? k.charCodeAt(p + 2) : 0, v = t >> 2, x = (t & 3) << 4 | q >> 4, y = (q & 15) << 2 | u >> 6, w = u & 63; n || (w = 64, r || (y = 64)); l.push(Qf[v], Qf[x], Qf[y], Qf[w]) } h = l.join(""); f.call(e, h) } } var z = b.join("*"); return ["1", fg(z),
            z].join("*")
    }, fg = function (a, b) { var c = [window.navigator.userAgent, (new Date).getTimezoneOffset(), window.navigator.userLanguage || window.navigator.language, Math.floor((new Date).getTime() / 60 / 1E3) - (void 0 === b ? 0 : b), a].join("*"), d; if (!(d = Uf)) { for (var e = Array(256), f = 0; 256 > f; f++) { for (var h = f, k = 0; 8 > k; k++)h = h & 1 ? h >>> 1 ^ 3988292384 : h >>> 1; e[f] = h } d = e } Uf = d; for (var l = 4294967295, p = 0; p < c.length; p++)l = l >>> 8 ^ Uf[(l ^ c.charCodeAt(p)) & 255]; return ((l ^ -1) >>> 0).toString(36) }, ig = function () {
        return function (a) {
            var b = le(G.location.href),
            c = b.search.replace("?", ""), d = ge(c, "_gl", !0) || ""; a.query = hg(d) || {}; var e = je(b, "fragment").match(eg("_gl")); a.fragment = hg(e && e[3] || "") || {}
        }
    }, jg = function (a) { var b = ig(), c = Xf(); c.data || (c.data = { query: {}, fragment: {} }, b(c.data)); var d = {}, e = c.data; e && (Ta(d, e.query), a && Ta(d, e.fragment)); return d }, hg = function (a) {
        var b; b = void 0 === b ? 3 : b; try {
            if (a) {
                var c; a: { for (var d = a, e = 0; 3 > e; ++e) { var f = ag.exec(d); if (f) { c = f; break a } d = decodeURIComponent(d) } c = void 0 } var h = c; if (h && "1" === h[1]) {
                    var k = h[3], l; a: {
                        for (var p = h[2], r = 0; r <
                            b; ++r)if (p === fg(k, r)) { l = !0; break a } l = !1
                    } if (l) { for (var n = {}, t = k ? k.split("*") : [], q = 0; q < t.length; q += 2)n[t[q]] = Tf(t[q + 1]); return n }
                }
            }
        } catch (u) { }
    }; function kg(a, b, c, d) { function e(r) { var n = r, t = eg(a).exec(n), q = n; if (t) { var u = t[2], v = t[4]; q = t[1]; v && (q = q + u + v) } r = q; var x = r.charAt(r.length - 1); r && "&" !== x && (r += "&"); return r + p } d = void 0 === d ? !1 : d; var f = dg.exec(c); if (!f) return ""; var h = f[1], k = f[2] || "", l = f[3] || "", p = a + "=" + b; d ? l = "#" + e(l.substring(1)) : k = "?" + e(k.substring(1)); return "" + h + k + l }
    function lg(a, b) { var c = "FORM" === (a.tagName || "").toUpperCase(), d = $f(b, 1, c), e = $f(b, 2, c), f = $f(b, 3, c); if (Va(d)) { var h = gg(d); c ? mg("_gl", h, a) : ng("_gl", h, a, !1) } if (!c && Va(e)) { var k = gg(e); ng("_gl", k, a, !0) } for (var l in f) if (f.hasOwnProperty(l)) a: { var p = l, r = f[l], n = a; if (n.tagName) { if ("a" === n.tagName.toLowerCase()) { ng(p, r, n, void 0); break a } if ("form" === n.tagName.toLowerCase()) { mg(p, r, n); break a } } "string" == typeof n && kg(p, r, n, void 0) } }
    function ng(a, b, c, d) { if (c.href) { var e = kg(a, b, c.href, void 0 === d ? !1 : d); Pc.test(e) && (c.href = e) } }
    function mg(a, b, c) { if (c && c.action) { var d = (c.method || "").toLowerCase(); if ("get" === d) { for (var e = c.childNodes || [], f = !1, h = 0; h < e.length; h++) { var k = e[h]; if (k.name === a) { k.setAttribute("value", b); f = !0; break } } if (!f) { var l = H.createElement("input"); l.setAttribute("type", "hidden"); l.setAttribute("name", a); l.setAttribute("value", b); c.appendChild(l) } } else if ("post" === d) { var p = kg(a, b, c.action); Pc.test(p) && (c.action = p) } } }
    var Vf = function (a) { try { var b; a: { for (var c = a, d = 100; c && 0 < d;) { if (c.href && c.nodeName.match(/^a(?:rea)?$/i)) { b = c; break a } c = c.parentNode; d-- } b = null } var e = b; if (e) { var f = e.protocol; "http:" !== f && "https:" !== f || lg(e, e.hostname) } } catch (h) { } }, Wf = function (a) { try { if (a.action) { var b = je(le(a.action), "host"); lg(a, b) } } catch (c) { } }, og = function (a, b, c, d) { Yf(); Zf(a, b, "fragment" === c ? 2 : 1, !!d, !1) }, pg = function (a, b) { Yf(); Zf(a, [ie(G.location, "host", !0)], b, !0, !0) }, qg = function () {
        var a = H.location.hostname, b = bg.exec(H.referrer); if (!b) return !1;
        var c = b[2], d = b[1], e = ""; if (c) { var f = c.split("/"), h = f[1]; e = "s" === h ? decodeURIComponent(f[2]) : decodeURIComponent(h) } else if (d) { if (0 === d.indexOf("xn--")) return !1; e = d.replace(/-/g, ".").replace(/\.\./g, "-") } var k = a.replace(cg, ""), l = e.replace(cg, ""), p; if (!(p = k === l)) { var r = "." + l; p = k.substring(k.length - r.length, k.length) === r } return p
    }, rg = function (a, b) { return !1 === a ? !1 : a || b || qg() }; var sg = /^\w+$/, tg = /^[\w-]+$/, ug = /^~?[\w-]+$/, vg = { aw: "_aw", dc: "_dc", gf: "_gf", ha: "_ha", gp: "_gp" }, wg = function () { if (!wd() || !Hd()) return !0; var a = Ed("ad_storage"); return null == a ? !0 : !!a }, xg = function (a, b) { Gd("ad_storage") ? wg() ? a() : Kd(a, "ad_storage") : b ? Bc("TAGGING", 3) : Jd(function () { xg(a, !0) }, ["ad_storage"]) }, Ag = function (a) { var b = []; if (!H.cookie) return b; var c = qf(a, H.cookie, void 0, "ad_storage"); if (!c || 0 == c.length) return b; for (var d = 0; d < c.length; d++) { var e = yg(c[d]); e && -1 === m(b, e) && b.push(e) } return zg(b) };
    function Bg(a) { return a && "string" == typeof a && a.match(sg) ? a : "_gcl" }
    var Dg = function () { var a = le(G.location.href), b = je(a, "query", !1, void 0, "gclid"), c = je(a, "query", !1, void 0, "gclsrc"), d = je(a, "query", !1, void 0, "dclid"); if (!b || !c) { var e = a.hash.replace("#", ""); b = b || ge(e, "gclid", void 0); c = c || ge(e, "gclsrc", void 0) } return Cg(b, c, d) }, Cg = function (a, b, c) {
        var d = {}, e = function (f, h) { d[h] || (d[h] = []); d[h].push(f) }; d.gclid = a; d.gclsrc = b; d.dclid = c; if (void 0 !== a && a.match(tg)) switch (b) {
            case void 0: e(a, "aw"); break; case "aw.ds": e(a, "aw"); e(a, "dc"); break; case "ds": e(a, "dc"); break; case "3p.ds": e(a,
                "dc"); break; case "gf": e(a, "gf"); break; case "ha": e(a, "ha"); break; case "gp": e(a, "gp")
        }c && e(c, "dc"); return d
    }, Eg = function (a, b) { switch (a) { case void 0: case "aw": return "aw" === b; case "aw.ds": return "aw" === b || "dc" === b; case "ds": case "3p.ds": return "dc" === b; case "gf": return "gf" === b; case "ha": return "ha" === b; case "gp": return "gp" === b }return !1 }, Gg = function (a) { var b = Dg(); xg(function () { Fg(b, a) }) };
    function Fg(a, b, c) { function d(l, p) { var r = Hg(l, e); r && zf(r, p, f) } b = b || {}; var e = Bg(b.prefix); c = c || Pa(); var f = Hf(b, c, !0); f.sa = "ad_storage"; var h = Math.round(c / 1E3), k = function (l) { return ["GCL", h, l].join(".") }; a.aw && (!0 === b.Pi ? d("aw", k("~" + a.aw[0])) : d("aw", k(a.aw[0]))); a.dc && d("dc", k(a.dc[0])); a.gf && d("gf", k(a.gf[0])); a.ha && d("ha", k(a.ha[0])); a.gp && d("gp", k(a.gp[0])) }
    var Jg = function (a, b) { var c = jg(!0); xg(function () { for (var d = Bg(b.prefix), e = 0; e < a.length; ++e) { var f = a[e]; if (void 0 !== vg[f]) { var h = Hg(f, d), k = c[h]; if (k) { var l = Math.min(Ig(k), Pa()), p; b: { for (var r = l, n = qf(h, H.cookie, void 0, "ad_storage"), t = 0; t < n.length; ++t)if (Ig(n[t]) > r) { p = !0; break b } p = !1 } if (!p) { var q = Hf(b, l, !0); q.sa = "ad_storage"; zf(h, k, q) } } } } Fg(Cg(c.gclid, c.gclsrc), b) }) }, Hg = function (a, b) { var c = vg[a]; if (void 0 !== c) return b + c }, Ig = function (a) {
        var b = a.split("."); return 3 !== b.length || "GCL" !== b[0] ? 0 : 1E3 * (Number(b[1]) ||
            0)
    }; function yg(a) { var b = a.split("."); if (3 == b.length && "GCL" == b[0] && b[1]) return b[2] }
    var Kg = function (a, b, c, d, e) { if (Aa(b)) { var f = Bg(e), h = function () { for (var k = {}, l = 0; l < a.length; ++l) { var p = Hg(a[l], f); if (p) { var r = qf(p, H.cookie, void 0, "ad_storage"); r.length && (k[p] = r.sort()[r.length - 1]) } } return k }; xg(function () { og(h, b, c, d) }) } }, zg = function (a) { return a.filter(function (b) { return ug.test(b) }) }, Lg = function (a, b) {
        for (var c = Bg(b.prefix), d = {}, e = 0; e < a.length; e++)vg[a[e]] && (d[a[e]] = vg[a[e]]); xg(function () {
            Ia(d, function (f, h) {
                var k = qf(c + h, H.cookie, void 0, "ad_storage"); if (k.length) {
                    var l = k[0], p = Ig(l),
                    r = {}; r[f] = [yg(l)]; Fg(r, b, p)
                }
            })
        })
    }; function Mg(a, b) { for (var c = 0; c < b.length; ++c)if (a[b[c]]) return !0; return !1 }
    var Ng = function () { function a(e, f, h) { h && (e[f] = h) } var b = ["aw", "dc"]; if (Hd()) { var c = Dg(); if (Mg(c, b)) { var d = {}; a(d, "gclid", c.gclid); a(d, "dclid", c.dclid); a(d, "gclsrc", c.gclsrc); pg(function () { return d }, 3); pg(function () { var e = {}; return e._up = "1", e }, 1) } } }, Og = function () {
        var a; if (wg()) {
            for (var b = [], c = H.cookie.split(";"), d = /^\s*_gac_(UA-\d+-\d+)=\s*(.+?)\s*$/, e = 0; e < c.length; e++) { var f = c[e].match(d); f && b.push({ Rd: f[1], value: f[2] }) } var h = {}; if (b && b.length) for (var k = 0; k < b.length; k++) {
                var l = b[k].value.split(".");
                "1" == l[0] && 3 == l.length && l[1] && (h[b[k].Rd] || (h[b[k].Rd] = []), h[b[k].Rd].push({ timestamp: l[1], vc: l[2] }))
            } a = h
        } else a = {}; return a
    }; var Pg = /^\d+\.fls\.doubleclick\.net$/, Qg = !1; function Rg(a, b) { Gd(E.B) ? Pd(E.B) ? a() : Kd(a, E.B) : b ? Dc(42) : Rd(function () { Rg(a, !0) }, [E.B]) } function Sg(a) { var b = le(G.location.href), c = je(b, "host", !1); if (c && c.match(Pg)) { var d = je(b, "path").split(a + "="); if (1 < d.length) return d[1].split(";")[0].split("?")[0] } }
    function Tg(a, b, c) { if ("aw" == a || "dc" == a) { var d = Sg("gcl" + a); if (d) return d.split(".") } var e = Bg(b); if ("_gcl" == e) { c = void 0 === c ? !0 : c; var f = !Pd(E.B) && c, h; h = Dg()[a] || []; if (0 < h.length) return f ? ["0"] : h } var k = Hg(a, e); return k ? Ag(k) : [] }
    var Ug = function (a) { var b = Sg("gac"); if (b) return !Pd(E.B) && a ? "0" : decodeURIComponent(b); var c = Og(), d = []; Ia(c, function (e, f) { for (var h = [], k = 0; k < f.length; k++)h.push(f[k].vc); h = zg(h); h.length && d.push(e + ":" + h.join(",")) }); return d.join(";") }, Wg = function (a, b) {
        if (Qg) Vg(a, b, "dc"); else {
            var c = Dg().dc || []; Rg(function () {
                Of(b); var d = Jf[Kf(b.prefix)], e = !1; if (d && 0 < c.length) {
                    var f = M.joined_au = M.joined_au || {}, h = b.prefix || "_gcl"; if (!f[h]) for (var k = 0; k < c.length; k++) {
                        var l = "https://adservice.google.com/ddm/regclk"; l = l + "?gclid=" + c[k] + "&auiddc=" +
                            d; td(l); e = f[h] = !0
                    }
                } null == a && (a = e); a && d && Mf(b)
            })
        }
    }, Vg = function (a, b, c) {
        var d = Dg(), e = [], f = d.gclid, h = d.dclid, k = d.gclsrc || "aw"; !f || "aw.ds" !== k && "aw" !== k && "ds" !== k || c && !Eg(k, c) || e.push({ vc: f, lf: k }); !h || c && "dc" !== c || e.push({ vc: h, lf: "ds" }); Rg(function () {
            Of(b); var l = Jf[Kf(b.prefix)], p = !1; if (l && 0 < e.length) for (var r = M.joined_auid = M.joined_auid || {}, n = 0; n < e.length; n++) {
                var t = e[n], q = t.vc, u = t.lf, v = (b.prefix || "_gcl") + "." + u + "." + q; if (!r[v]) {
                    var x = "https://adservice.google.com/pagead/regclk"; x = x + "?gclid=" + q + "&auid=" + l + "&gclsrc=" + u; td(x);
                    p = r[v] = !0
                }
            } null == a && (a = p); a && l && Mf(b)
        })
    }; var Xg = /[A-Z]+/, Yg = /\s/, Zg = function (a) { if (g(a) && (a = Oa(a), !Yg.test(a))) { var b = a.indexOf("-"); if (!(0 > b)) { var c = a.substring(0, b); if (Xg.test(c)) { for (var d = a.substring(b + 1).split("/"), e = 0; e < d.length; e++)if (!d[e]) return; return { id: a, prefix: c, containerId: c + "-" + d[0], F: d } } } } }, ah = function (a) { for (var b = {}, c = 0; c < a.length; ++c) { var d = Zg(a[c]); d && (b[d.id] = d) } $g(b); var e = []; Ia(b, function (f, h) { e.push(h) }); return e };
    function $g(a) { var b = [], c; for (c in a) if (a.hasOwnProperty(c)) { var d = a[c]; "AW" === d.prefix && d.F[1] && b.push(d.containerId) } for (var e = 0; e < b.length; ++e)delete a[b[e]] }; var bh = function () { var a = !1; return a }; var dh = function (a, b, c, d) { return (2 === ch() || d || "http:" != G.location.protocol ? a : b) + c }, ch = function () { var a = kd(), b; if (1 === a) a: { var c = Oe; c = c.toLowerCase(); for (var d = "https://" + c, e = "http://" + c, f = 1, h = H.getElementsByTagName("script"), k = 0; k < h.length && 100 > k; k++) { var l = h[k].src; if (l) { l = l.toLowerCase(); if (0 === l.indexOf(e)) { b = 3; break a } 1 === f && 0 === l.indexOf(d) && (f = 2) } } b = f } else b = a; return b };
    var fh = function (a, b, c) { if (G[a.functionName]) return b.Dd && I(b.Dd), G[a.functionName]; var d = eh(); G[a.functionName] = d; if (a.kc) for (var e = 0; e < a.kc.length; e++)G[a.kc[e]] = G[a.kc[e]] || eh(); a.xc && void 0 === G[a.xc] && (G[a.xc] = c); jd(dh("https://", "http://", a.Od), b.Dd, b.Mh); return d }, eh = function () { var a = function () { a.q = a.q || []; a.q.push(arguments) }; return a }, gh = { functionName: "_googWcmImpl", xc: "_googWcmAk", Od: "www.gstatic.com/wcm/loader.js" }, hh = { functionName: "_gaPhoneImpl", xc: "ga_wpid", Od: "www.gstatic.com/gaphone/loader.js" },
        ih = { Gf: "", Cg: "5" }, jh = { functionName: "_googCallTrackingImpl", kc: [hh.functionName, gh.functionName], Od: "www.gstatic.com/call-tracking/call-tracking_" + (ih.Gf || ih.Cg) + ".js" }, kh = {}, lh = function (a, b, c, d) { Dc(22); if (c) { d = d || {}; var e = fh(gh, d, a), f = { ak: a, cl: b }; void 0 === d.oa && (f.autoreplace = c); e(2, d.oa, f, c, 0, new Date, d.options) } }, mh = function (a, b, c, d) {
            Dc(21); if (b && c) {
                d = d || {}; for (var e = { countryNameCode: c, destinationNumber: b, retrievalTime: new Date }, f = 0; f < a.length; f++) {
                    var h = a[f];
                    kh[h.id] || (h && "AW" === h.prefix && !e.adData && 2 <= h.F.length ? (e.adData = { ak: h.F[0], cl: h.F[1] }, kh[h.id] = !0) : h && "UA" === h.prefix && !e.gaData && (e.gaData = { gaWpid: h.containerId }, kh[h.id] = !0))
                } (e.gaData || e.adData) && fh(jh, d)(d.oa, e, d.options)
            }
        }, nh = function () { var a = !1; return a }, oh = function (a, b) {
            if (a) if (bh()) { } else {
                if (g(a)) {
                    var c =
                        Zg(a); if (!c) return; a = c
                } var d = void 0, e = !1, f = b.getWithConfig(E.kg); if (f && Aa(f)) { d = []; for (var h = 0; h < f.length; h++) { var k = Zg(f[h]); k && (d.push(k), (a.id === k.id || a.id === a.containerId && a.containerId === k.containerId) && (e = !0)) } } if (!d || e) {
                    var l = b.getWithConfig(E.Ce), p; if (l) {
                        Aa(l) ? p = l : p = [l]; var r = b.getWithConfig(E.Ae), n = b.getWithConfig(E.Be), t = b.getWithConfig(E.De), q = b.getWithConfig(E.jg), u = r || n, v = 1; "UA" !== a.prefix || d || (v = 5); for (var x = 0; x < p.length; x++)if (x < v) if (d) mh(d, p[x], q, { oa: u, options: t }); else if ("AW" === a.prefix &&
                            a.F[1]) nh() ? mh([a], p[x], q || "US", { oa: u, options: t }) : lh(a.F[0], a.F[1], p[x], { oa: u, options: t }); else if ("UA" === a.prefix) if (nh()) mh([a], p[x], q || "US", { oa: u }); else { var y = a.containerId, w = p[x], z = { oa: u }; Dc(23); if (w) { z = z || {}; var A = fh(hh, z, y), B = {}; void 0 !== z.oa ? B.receiver = z.oa : B.replace = w; B.ga_wpid = y; B.destination = w; A(2, new Date, B) } }
                    }
                }
            }
        };
    var rh = function (a) { return Pd(E.B) ? a : a.replace(/&url=([^&#]+)/, function (b, c) { var d = me(decodeURIComponent(c)); return "&url=" + encodeURIComponent(d) }) }, sh = function () { var a; if (!(a = Pe)) { var b; if (!0 === G._gtmdgs) b = !0; else { var c = ad && ad.userAgent || ""; b = 0 > c.indexOf("Safari") || /Chrome|Coast|Opera|Edg|Silk|Android/.test(c) || 11 > ((/Version\/([\d]+)/.exec(c) || [])[1] || "") ? !1 : !0 } a = !b } if (a) return -1; var d = Ka("1"); return lf(1, 100) < d ? lf(2, 2) : -1 }, th = function (a) {
        var b;
        if (!a || !a.length) return; for (var c = [], d = 0; d < a.length; ++d) { var e = a[d]; e && e.estimated_delivery_date ? c.push("" + e.estimated_delivery_date) : c.push("") } b = c.join(","); return b
    }; var uh = new RegExp(/^(.*\.)?(google|youtube|blogger|withgoogle)(\.com?)?(\.[a-z]{2})?\.?$/), vh = { cl: ["ecl"], customPixels: ["nonGooglePixels"], ecl: ["cl"], ehl: ["hl"], hl: ["ehl"], html: ["customScripts", "customPixels", "nonGooglePixels", "nonGoogleScripts", "nonGoogleIframes"], customScripts: ["html", "customPixels", "nonGooglePixels", "nonGoogleScripts", "nonGoogleIframes"], nonGooglePixels: [], nonGoogleScripts: ["nonGooglePixels"], nonGoogleIframes: ["nonGooglePixels"] }, wh = {
        cl: ["ecl"], customPixels: ["customScripts", "html"],
        ecl: ["cl"], ehl: ["hl"], hl: ["ehl"], html: ["customScripts"], customScripts: ["html"], nonGooglePixels: ["customPixels", "customScripts", "html", "nonGoogleScripts", "nonGoogleIframes"], nonGoogleScripts: ["customScripts", "html"], nonGoogleIframes: ["customScripts", "html", "nonGoogleScripts"]
    }, xh = "google customPixels customScripts html nonGooglePixels nonGoogleScripts nonGoogleIframes".split(" ");
    var zh = function (a) {
        var b = af("gtm.allowlist") || af("gtm.whitelist"); b && Dc(9); b = "google gtagfl lcl zone oid op".split(" "); var c = b && Wa(Na(b), vh), d = af("gtm.blocklist") || af("gtm.blacklist"); d || (d = af("tagTypeBlacklist")) &&
            Dc(3); d ? Dc(8) : d = []; yh() && (d = Na(d), d.push("nonGooglePixels", "nonGoogleScripts", "sandboxedScripts")); 0 <= m(Na(d), "google") && Dc(2); var e = d && Wa(Na(d), wh), f = {}; return function (h) {
                var k = h && h[Xb.Ma]; if (!k || "string" != typeof k) return !0; k = k.replace(/^_*/, ""); if (void 0 !== f[k]) return f[k]; var l = Ue[k] || [], p = a(k, l); if (b) {
                    var r; if (r = p) a: {
                        if (0 > m(c, k)) if (l && 0 < l.length) for (var n = 0; n <
                            l.length; n++) { if (0 > m(c, l[n])) { Dc(11); r = !1; break a } } else { r = !1; break a } r = !0
                    } p = r
                } var t = !1; if (d) { var q = 0 <= m(e, k); if (q) t = q; else { var u = Ga(e, l || []); u && Dc(10); t = u } } var v = !p || t; v || !(0 <= m(l, "sandboxedScripts")) || c && -1 !== m(c, "sandboxedScripts") || (v = Ga(e, xh)); return f[k] = v
            }
    }, yh = function () { return uh.test(G.location && G.location.hostname) }; var Ah = { active: !0, isAllowed: function () { return !0 } }, Bh = function (a) { var b = M.zones; return b ? b.checkState(Ie.D, a) : Ah }, Ch = function (a) { var b = M.zones; !b && a && (b = M.zones = a()); return b }; var Hh = function () { }, Ih = function () { }; var Jh = !1, Kh = 0, Lh = []; function Mh(a) { if (!Jh) { var b = H.createEventObject, c = "complete" == H.readyState, d = "interactive" == H.readyState; if (!a || "readystatechange" != a.type || c || !b && d) { Jh = !0; for (var e = 0; e < Lh.length; e++)I(Lh[e]) } Lh.push = function () { for (var f = 0; f < arguments.length; f++)I(arguments[f]); return 0 } } } function Nh() { if (!Jh && 140 > Kh) { Kh++; try { H.documentElement.doScroll("left"), Mh() } catch (a) { G.setTimeout(Nh, 50) } } } var Oh = function (a) { Jh ? a() : Lh.push(a) }; var Ph = {}, Qh = {}, Rh = function (a, b, c, d) { if (!Qh[a] || Le[b] || "__zone" === b) return -1; var e = {}; gb(d) && (e = C(d, e)); e.id = c; e.status = "timeout"; return Qh[a].tags.push(e) - 1 }, Sh = function (a, b, c, d) { if (Qh[a]) { var e = Qh[a].tags[b]; e && (e.status = c, e.executionTime = d) } }; function Th(a) { for (var b = Ph[a] || [], c = 0; c < b.length; c++)b[c](); Ph[a] = { push: function (d) { d(Ie.D, Qh[a]) } } }
    var Wh = function (a, b, c) { Qh[a] = { tags: [] }; ya(b) && Uh(a, b); c && G.setTimeout(function () { return Th(a) }, Number(c)); return Vh(a) }, Uh = function (a, b) { Ph[a] = Ph[a] || []; Ph[a].push(Sa(function () { return I(function () { b(Ie.D, Qh[a]) }) })) }; function Vh(a) { var b = 0, c = 0, d = !1; return { add: function () { c++; return Sa(function () { b++; d && b >= c && Th(a) }) }, Og: function () { d = !0; b >= c && Th(a) } } }; var Xh = function () { function a(d) { return !za(d) || 0 > d ? 0 : d } if (!M._li && G.performance && G.performance.timing) { var b = G.performance.timing.navigationStart, c = za(bf.get("gtm.start")) ? bf.get("gtm.start") : 0; M._li = { cst: a(c - b), cbt: a(Re - b) } } }; var ai = {}, bi = function () { return G.GoogleAnalyticsObject && G[G.GoogleAnalyticsObject] }, ci = !1;
    var di = function (a) { G.GoogleAnalyticsObject || (G.GoogleAnalyticsObject = a || "ga"); var b = G.GoogleAnalyticsObject; if (G[b]) G.hasOwnProperty(b) || Dc(12); else { var c = function () { c.q = c.q || []; c.q.push(arguments) }; c.l = Number(new Date); G[b] = c } Xh(); return G[b] }, ei = function (a, b, c, d) { b = String(b).replace(/\s+/g, "").split(","); var e = bi(); e(a + "require", "linker"); e(a + "linker:autoLink", b, c, d) }, fi = function (a) { };
    var hi = function (a) { }, gi = function () { return G.GoogleAnalyticsObject || "ga" }, ii = function (a, b) {
        return function () {
            var c = bi(), d = c && c.getByName && c.getByName(a); if (d) {
                var e = d.get("sendHitTask"); d.set("sendHitTask", function (f) {
                    var h = f.get("hitPayload"), k = f.get("hitCallback"), l = 0 > h.indexOf("&tid=" + b); l && (f.set("hitPayload", h.replace(/&tid=UA-[0-9]+-[0-9]+/, "&tid=" +
                        b), !0), f.set("hitCallback", void 0, !0)); e(f); l && (f.set("hitPayload", h, !0), f.set("hitCallback", k, !0), f.set("_x_19", void 0, !0), e(f))
                })
            }
        }
    };
    var ni = function () { return "&tc=" + Mb.filter(function (a) { return a }).length }, qi = function () { 2022 <= oi().length && pi() }, si = function () { ri || (ri = G.setTimeout(pi, 500)) }, pi = function () { ri && (G.clearTimeout(ri), ri = void 0); void 0 === ti || ui[ti] && !vi && !wi || (xi[ti] || yi.Bh() || 0 >= zi-- ? (Dc(1), xi[ti] = !0) : (yi.Xh(), md(oi()), ui[ti] = !0, Ai = Bi = Ci = wi = vi = "")) }, oi = function () { var a = ti; if (void 0 === a) return ""; var b = Cc("GTM"), c = Cc("TAGGING"); return [Di, ui[a] ? "" : "&es=1", Ei[a], b ? "&u=" + b : "", c ? "&ut=" + c : "", ni(), vi, wi, Ci ? Ci : "", Bi, Ai, "&z=0"].join("") },
        Fi = function () { return [Se, "&v=3&t=t", "&pid=" + Da(), "&rv=" + Ie.ic].join("") }, Gi = "0.005000" > Math.random(), Di = Fi(), Hi = function () { Di = Fi() }, ui = {}, vi = "", wi = "", Ai = "", Bi = "", Ci = "", ti = void 0, Ei = {}, xi = {}, ri = void 0, yi = function (a, b) { var c = 0, d = 0; return { Bh: function () { if (c < a) return !1; Pa() - d >= b && (c = 0); return c >= a }, Xh: function () { Pa() - d >= b && (c = 0); c++; d = Pa() } } }(2, 1E3), zi = 1E3, Ii = function (a, b, c) {
            if (Gi && !xi[a] && b) {
                a !== ti && (pi(), ti = a); var d, e = String(b[Xb.Ma] || "").replace(/_/g, ""); 0 === e.indexOf("cvt") && (e = "cvt");
                d = e; var f = c + d; vi = vi ? vi + "." + f : "&tr=" + f; var h = b["function"]; if (!h) throw Error("Error: No function name given for function call."); var k = (Ob[h] ? "1" : "2") + d; Ai = Ai ? Ai + "." + k : "&ti=" + k; si(); qi()
            }
        }, Ji = function (a, b, c) { if (Gi && !xi[a]) { a !== ti && (pi(), ti = a); var d = c + b; wi = wi ? wi + "." + d : "&epr=" + d; si(); qi() } }, Ki = function (a, b, c) { };
    function Li(a, b, c, d) { var e = Mb[a], f = Mi(a, b, c, d); if (!f) return null; var h = Ub(e[Xb.Ue], c, []); if (h && h.length) { var k = h[0]; f = Li(k.index, { onSuccess: f, onFailure: 1 === k.ef ? b.terminate : f, terminate: b.terminate }, c, d) } return f }
    function Mi(a, b, c, d) {
        function e() {
            if (f[Xb.xg]) k(); else {
                var x = Vb(f, c, []); var z = Rh(c.id, String(f[Xb.Ma]), Number(f[Xb.Ve]), x[Xb.yg]), A = !1; x.vtp_gtmOnSuccess = function () {
                    if (!A) {
                        A = !0; var F = Pa() - D; Ii(c.id, Mb[a], "5"); Sh(c.id, z, "success",
                            F); h()
                    }
                }; x.vtp_gtmOnFailure = function () { if (!A) { A = !0; var F = Pa() - D; Ii(c.id, Mb[a], "6"); Sh(c.id, z, "failure", F); k() } }; x.vtp_gtmTagId = f.tag_id; x.vtp_gtmEventId = c.id; Ii(c.id, f, "1"); var B = function () { var F = Pa() - D; Ii(c.id, f, "7"); Sh(c.id, z, "exception", F); A || (A = !0, k()) }; var D = Pa(); try { Tb(x, c) } catch (F) { B(F) }
            }
        } var f = Mb[a], h = b.onSuccess, k = b.onFailure, l = b.terminate; if (c.yd(f)) return null; var p = Ub(f[Xb.We], c, []); if (p && p.length) { var r = p[0], n = Li(r.index, { onSuccess: h, onFailure: k, terminate: l }, c, d); if (!n) return null; h = n; k = 2 === r.ef ? l : n } if (f[Xb.Qe] || f[Xb.Ag]) {
            var t = f[Xb.Qe] ? Nb :
                c.ei, q = h, u = k; if (!t[a]) { e = Sa(e); var v = Ni(a, t, e); h = v.onSuccess; k = v.onFailure } return function () { t[a](q, u) }
        } return e
    } function Ni(a, b, c) { var d = [], e = []; b[a] = Oi(d, e, c); return { onSuccess: function () { b[a] = Pi; for (var f = 0; f < d.length; f++)d[f]() }, onFailure: function () { b[a] = Qi; for (var f = 0; f < e.length; f++)e[f]() } } } function Oi(a, b, c) { return function (d, e) { a.push(d); b.push(e); c() } } function Pi(a) { a() } function Qi(a, b) { b() }; var Ti = function (a, b, c) {
        for (var d = [], e = 0; e < Mb.length; e++)if (a[e]) { var f = Mb[e]; var h = c.add(); try { var k = Li(e, { onSuccess: h, onFailure: h, terminate: h }, b, e); if (k) { var l = d, p = l.push, r = e, n = f["function"]; if (!n) throw "Error: No function name given for function call."; var t = Ob[n]; p.call(l, { Cf: r, vf: t ? t.priorityOverride || 0 : 0, lh: k }) } else Ri(e, b), h() } catch (u) { h() } } c.Og(); d.sort(Si); for (var q = 0; q < d.length; q++)d[q].lh(); return 0 <
            d.length
    }; function Si(a, b) { var c, d = b.vf, e = a.vf; c = d > e ? 1 : d < e ? -1 : 0; var f; if (0 !== c) f = c; else { var h = a.Cf, k = b.Cf; f = h > k ? 1 : h < k ? -1 : 0 } return f } function Ri(a, b) { if (!Gi) return; var c = function (d) { var e = b.yd(Mb[d]) ? "3" : "4", f = Ub(Mb[d][Xb.Ue], b, []); f && f.length && c(f[0].index); Ii(b.id, Mb[d], e); var h = Ub(Mb[d][Xb.We], b, []); h && h.length && c(h[0].index) }; c(a); }
    var Ui = !1, Zi = function (a) {
        var b = a["gtm.uniqueEventId"], c = a.event; if ("gtm.js" === c) { if (Ui) return !1; Ui = !0 } var d = Bh(b), e = !1; if (!d.active) { if ("gtm.js" !== c) return !1; e = !0; d = Bh(Number.MAX_SAFE_INTEGER) } Gi && !xi[b] && ti !== b && (pi(), ti = b, Ai = vi = "", Ei[b] = "&e=" + (0 === c.indexOf("gtm.") ? encodeURIComponent(c) : "*") + "&eid=" + b, si()); var f = { id: b, name: c, yd: zh(d.isAllowed), ei: [], qf: function () { Dc(6) }, $e: Vi(b) }, h = Wh(b, a.eventCallback, a.eventTimeout); Wi(b);
        var k = ac(f); e && (k = Xi(k)); var l = Ti(k, f, h); "gtm.js" !== c && "gtm.sync" !== c || hi(Ie.D); switch (c) { case "gtm.init": Dc(19), l && Dc(20) }return Yi(k, l)
    }; function Vi(a) { return function (b) { Gi && (hb(b) || Ki(a, "input", b)) } }
    function Wi(a) { ef(a, "event", 1); ef(a, "ecommerce", 1); ef(a, "gtm"); ef(a, "eventModel"); } function Xi(a) { for (var b = [], c = 0; c < a.length; c++)a[c] && Ke[String(Mb[c][Xb.Ma])] && (b[c] = !0); return b } function Yi(a, b) { if (!b) return b; for (var c = 0; c < a.length; c++)if (a[c] && Mb[c] && !Le[String(Mb[c][Xb.Ma])]) return !0; return !1 } function $i(a, b) { if (a) { var c = "" + a; 0 !== c.indexOf("http://") && 0 !== c.indexOf("https://") && (c = "https://" + c); "/" === c[c.length - 1] && (c = c.substring(0, c.length - 1)); return le("" + c + b).href } } function aj(a, b) { return bj() ? $i(a, b) : void 0 } function bj() { var a = !1; return a }; var cj = function () { this.eventModel = {}; this.targetConfig = {}; this.containerConfig = {}; this.remoteConfig = {}; this.globalConfig = {}; this.onSuccess = function () { }; this.onFailure = function () { }; this.setContainerTypeLoaded = function () { }; this.getContainerTypeLoaded = function () { }; this.eventId = void 0 }, dj = function (a) { var b = new cj; b.eventModel = a; return b }, ej = function (a, b) { a.targetConfig = b; return a }, fj = function (a, b) { a.containerConfig = b; return a }, gj = function (a, b) { a.remoteConfig = b; return a }, hj = function (a, b) {
        a.globalConfig =
        b; return a
    }, ij = function (a, b) { a.onSuccess = b; return a }, jj = function (a, b) { a.setContainerTypeLoaded = b; return a }, kj = function (a, b) { a.getContainerTypeLoaded = b; return a }, lj = function (a, b) { a.onFailure = b; return a }; cj.prototype.getWithConfig = function (a) { if (void 0 !== this.eventModel[a]) return this.eventModel[a]; if (void 0 !== this.targetConfig[a]) return this.targetConfig[a]; if (void 0 !== this.containerConfig[a]) return this.containerConfig[a]; if (void 0 !== this.remoteConfig[a]) return this.remoteConfig[a]; if (void 0 !== this.globalConfig[a]) return this.globalConfig[a] };
    var mj = function (a) { function b(e) { Ia(e, function (f) { c[f] = null }) } var c = {}; b(a.eventModel); b(a.targetConfig); b(a.containerConfig); b(a.globalConfig); var d = []; Ia(c, function (e) { d.push(e) }); return d }; var nj; if (3 === Ie.ic.length) nj = "g"; else { var oj = "G"; oj = "g"; nj = oj }
    var pj = { "": "n", UA: "u", AW: "a", DC: "d", G: "e", GF: "f", HA: "h", GTM: nj, OPT: "o" }, qj = function (a) { var b = Ie.D.split("-"), c = b[0].toUpperCase(), d = pj[c] || "i", e = a && "GTM" === c ? b[1] : "OPT" === c ? b[1] : "", f; if (3 === Ie.ic.length) { var h = "w"; h = bh() ? "s" : "o"; f = "2" + h } else f = ""; return f + d + Ie.ic + e }; var rj = function (a, b) { a.addEventListener && a.addEventListener.call(a, "message", b, !1) }; var sj = function () { return Tc("iPhone") && !Tc("iPod") && !Tc("iPad") }; Tc("Opera"); Tc("Trident") || Tc("MSIE"); Tc("Edge"); !Tc("Gecko") || -1 != Qc.toLowerCase().indexOf("webkit") && !Tc("Edge") || Tc("Trident") || Tc("MSIE") || Tc("Edge"); -1 != Qc.toLowerCase().indexOf("webkit") && !Tc("Edge") && Tc("Mobile"); Tc("Macintosh"); Tc("Windows"); Tc("Linux") || Tc("CrOS"); var tj = qa.navigator || null; tj && (tj.appVersion || "").indexOf("X11"); Tc("Android"); sj(); Tc("iPad"); Tc("iPod"); sj() || Tc("iPad") || Tc("iPod"); Qc.toLowerCase().indexOf("kaios"); var uj = function (a, b) { for (var c = a, d = 0; 50 > d; ++d) { var e; try { e = !(!c.frames || !c.frames[b]) } catch (k) { e = !1 } if (e) return c; var f; a: { try { var h = c.parent; if (h && h != c) { f = h; break a } } catch (k) { } f = null } if (!(c = f)) break } return null }; var vj = function () { }; var wj = function (a) { void 0 !== a.addtlConsent && "string" !== typeof a.addtlConsent && (a.addtlConsent = void 0); void 0 !== a.gdprApplies && "boolean" !== typeof a.gdprApplies && (a.gdprApplies = void 0); return void 0 !== a.tcString && "string" !== typeof a.tcString || void 0 !== a.listenerId && "number" !== typeof a.listenerId ? 2 : a.cmpStatus && "error" !== a.cmpStatus ? 0 : 3 }, xj = function (a, b) { this.o = a; this.m = null; this.K = {}; this.va = 0; this.ja = void 0 === b ? 500 : b; this.C = null }; pa(xj, vj);
    var zj = function (a) { return "function" === typeof a.o.__tcfapi || null != yj(a) };
    xj.prototype.addEventListener = function (a) {
        var b = {}, c = Gc(function () { return a(b) }), d = 0; -1 !== this.ja && (d = setTimeout(function () { b.tcString = "tcunavailable"; b.internalErrorState = 1; c() }, this.ja)); var e = function (f, h) { clearTimeout(d); f ? (b = f, b.internalErrorState = wj(b), h && 0 === b.internalErrorState || (b.tcString = "tcunavailable", h || (b.internalErrorState = 3))) : (b.tcString = "tcunavailable", b.internalErrorState = 3); a(b) }; try { Aj(this, "addEventListener", e) } catch (f) {
            b.tcString = "tcunavailable", b.internalErrorState = 3, d && (clearTimeout(d),
                d = 0), c()
        }
    }; xj.prototype.removeEventListener = function (a) { a && a.listenerId && Aj(this, "removeEventListener", null, a.listenerId) };
    var Cj = function (a, b, c) {
        var d; d = void 0 === d ? "755" : d; var e; a: { if (a.publisher && a.publisher.restrictions) { var f = a.publisher.restrictions[b]; if (void 0 !== f) { e = f[void 0 === d ? "755" : d]; break a } } e = void 0 } var h = e; if (0 === h) return !1; var k = c; 2 === c ? (k = 0, 2 === h && (k = 1)) : 3 === c && (k = 1, 1 === h && (k = 0)); var l; if (0 === k) if (a.purpose && a.vendor) { var p = Bj(a.vendor.consents, void 0 === d ? "755" : d); l = p && "1" === b && a.purposeOneTreatment && "DE" === a.publisherCC ? !0 : p && Bj(a.purpose.consents, b) } else l = !0; else l = 1 === k ? a.purpose && a.vendor ? Bj(a.purpose.legitimateInterests,
            b) && Bj(a.vendor.legitimateInterests, void 0 === d ? "755" : d) : !0 : !0; return l
    }, Bj = function (a, b) { return !(!a || !a[b]) }, Aj = function (a, b, c, d) { c || (c = function () { }); if ("function" === typeof a.o.__tcfapi) { var e = a.o.__tcfapi; e(b, 2, c, d) } else if (yj(a)) { Dj(a); var f = ++a.va; a.K[f] = c; if (a.m) { var h = {}; a.m.postMessage((h.__tcfapiCall = { command: b, version: 2, callId: f, parameter: d }, h), "*") } } else c({}, !1) }, yj = function (a) { if (a.m) return a.m; a.m = uj(a.o, "__tcfapiLocator"); return a.m }, Dj = function (a) {
        a.C || (a.C = function (b) {
            try {
                var c; c = ("string" ===
                    typeof b.data ? JSON.parse(b.data) : b.data).__tcfapiReturn; a.K[c.callId](c.returnValue, c.success)
            } catch (d) { }
        }, rj(a.o, a.C))
    }; var Ej = { 1: 0, 3: 0, 4: 0, 7: 3, 9: 3, 10: 3 }; function Fj(a, b) { if ("" === a) return b; var c = Number(a); return isNaN(c) ? b : c } var Gj = Fj("", 550), Hj = Fj("", 500); function Ij() { var a = M.tcf || {}; return M.tcf = a }
    var Jj = function (a, b) { this.C = a; this.m = b; this.o = Pa(); }, Kj = function (a) { }, Lj = function (a) { }, Rj = function () {
        var a = Ij(), b = new xj(G, 3E3), c = new Jj(b, a); if ((Mj() ? !0 === G.gtag_enable_tcf_support : !1 !== G.gtag_enable_tcf_support) && !a.active && ("function" === typeof G.__tcfapi || zj(b))) {
            a.active = !0; a.Mb = {}; Nj(); var d = setTimeout(function () { Oj(a); Pj(a); d = null }, Hj); try {
                b.addEventListener(function (e) {
                    d && (clearTimeout(d), d = null); if (0 !== e.internalErrorState) Oj(a), Pj(a), Kj(c); else {
                        var f; if (!1 === e.gdprApplies) f = Qj(), b.removeEventListener(e);
                        else if ("tcloaded" === e.eventStatus || "useractioncomplete" === e.eventStatus || "cmpuishown" === e.eventStatus) {
                            var h = {}, k; for (k in Ej) if (Ej.hasOwnProperty(k)) if ("1" === k) {
                                var l = e, p = !0; p = void 0 === p ? !1 : p; var r; var n = l; !1 === n.gdprApplies ? r = !0 : (void 0 === n.internalErrorState && (n.internalErrorState = wj(n)), r = "error" === n.cmpStatus || 0 !== n.internalErrorState || "loaded" === n.cmpStatus && ("tcloaded" === n.eventStatus || "useractioncomplete" === n.eventStatus) ? !0 : !1); h["1"] = r ? !1 === l.gdprApplies || "tcunavailable" === l.tcString ||
                                    void 0 === l.gdprApplies && !p || "string" !== typeof l.tcString || !l.tcString.length ? !0 : Cj(l, "1", 0) : !1
                            } else h[k] = Cj(e, k, Ej[k]); f = h
                        } f && (a.tcString = e.tcString || "tcempty", a.Mb = f, Pj(a), Kj(c))
                    }
                }), Lj(c)
            } catch (e) { d && (clearTimeout(d), d = null), Oj(a), Pj(a) }
        }
    }; function Oj(a) { a.type = "e"; a.tcString = "tcunavailable"; a.Mb = Qj() } function Nj() { var a = {}; Nd((a.ad_storage = "denied", a.wait_for_update = Gj, a)) }
    var Mj = function () { var a = !1; a = !0; return a }; function Qj() { var a = {}, b; for (b in Ej) Ej.hasOwnProperty(b) && (a[b] = !0); return a } function Pj(a) { var b = {}; Od((b.ad_storage = a.Mb["1"] ? "granted" : "denied", b)) }
    var Sj = function () { var a = Ij(); if (a.active && void 0 !== a.loadTime) return Number(a.loadTime) }, Tj = function () { var a = Ij(); return a.active ? a.tcString || "" : "" }, Uj = function (a) { if (!Ej.hasOwnProperty(String(a))) return !0; var b = Ij(); return b.active && b.Mb ? !!b.Mb[String(a)] : !0 }; var Vj = !1; function Wj(a) { var b = String(G.location).split(/[?#]/)[0], c = Ie.Kf || G._CONSENT_MODE_SALT; return a ? c ? String(nf(b + a + c)) : "0" : "" }
    function Xj(a) {
        function b(q) {
            var u; M.reported_gclid || (M.reported_gclid = {}); u = M.reported_gclid; var v; v = Vj && h && (!Hd() || Pd(E.B)) ? l + "." + (f.prefix || "_gcl") + (q ? "gcu" : "gcs") : l + (q ? "gcu" : "gcs"); if (!u[v]) {
                u[v] = !0; var x = [], y = function (D, F) { F && x.push(D + "=" + encodeURIComponent(F)) }, w = "https://www.google.com"; if (Hd()) {
                    var z = Pd(E.B); y("gcs", Qd()); q && y("gcu", "1"); M.dedupe_gclid ||
                        (M.dedupe_gclid = "" + Cf()); y("rnd", M.dedupe_gclid); if ((!l || p && "aw.ds" !== p) && Pd(E.B)) { var A = Ag("_gcl_aw"); y("gclaw", A.join(".")) } y("url", String(G.location).split(/[?#]/)[0]); y("dclid", Yj(d, r)); !z && d && (w = "https://pagead2.googlesyndication.com")
                } y("gdpr_consent", Tj()); "1" === jg(!1)._up && y("gtm_up", "1"); y("gclid", Yj(d,
                    l)); y("gclsrc", p); y("gtm", qj(!e)); Vj && h && Pd(E.B) && (Of(f || {}), y("auid", Jf[Kf(f.prefix)] || "")); var B = w + "/pagead/landing?" + x.join("&"); td(B)
            }
        } var c = !!a.pd, d = !!a.qa, e = a.R, f = void 0 === a.nc ? {} : a.nc, h = void 0 === a.yc ? !0 : a.yc, k = Dg(), l = k.gclid || "", p = k.gclsrc, r = k.dclid || "", n = !c && (!l || p && "aw.ds" !== p ? !1 : !0), t = Hd(); if (n || t) t ? Rd(function () { b(); Pd(E.B) || Kd(function (q) { return b(!0, q.af) }, E.B) }, [E.B]) : b()
    } function Yj(a, b) { var c = a && !Pd(E.B); return b && c ? "0" : b }
    var Zj = function (a) { var b = aj(a, "/pagead/conversion_async.js"); if (b) return b; var c = -1 !== navigator.userAgent.toLowerCase().indexOf("firefox"), d = dh("https://", "http://", "www.googleadservices.com"); if (c || 1 === sh()) d = "https://www.google.com"; return d + "/pagead/conversion_async.js" }, ak = !1, bk = [], ck = ["aw", "dc"], dk = function (a) { var b = G.google_trackConversion, c = a.gtm_onFailure; "function" == typeof b ? b(a) || c() : c() }, ek = function () { for (; 0 < bk.length;)dk(bk.shift()) }, fk = function (a, b) { var c = !1; var d = ak; c && (d = b.getContainerTypeLoaded("AW")); if (!d) { ak = !0; Xh(); var e = function () { c && b.setContainerTypeLoaded("AW", !0); ek(); bk = { push: dk } }; bh() ? e() : jd(a, e, function () { ek(); ak = !1; c && b.setContainerTypeLoaded("AW", !1) }) } }, gk = function (a) { if (a) { for (var b = [], c = 0; c < a.length; ++c) { var d = a[c]; d && b.push({ item_id: d.id, quantity: d.quantity, value: d.price, start_date: d.start_date, end_date: d.end_date }) } return b } }, hk = function (a, b, c, d) {
        function e() { wa("gdpr_consent", Tj()); } function f() { var R = []; return R } function h(R) {
            var ka = !0, Ca = []; if (R) { Ca = f(); } t && (V("delopc", q(E.dd)), V("oedeld", q(E.ye)),
                V("delc", q(E.oe)), V("shf", q(E.ve)), V("iedeld", th(q(E.U)))); ka && bk.push(L)
        } function k() { return function (R) { u && (R = rh(R)); return R } } var l = Zg(a), p = b == E.ca, r = l.F[0], n = l.F[1], t = void 0 !== n, q = function (R) { return d.getWithConfig(R) }, u = void 0 != q(E.M) && !1 !== q(E.M), v = !1 !== q(E.pb), x = q(E.ob) || q(E.X), y = q(E.V), w = q(E.fa), z = q(E.la), A = q(E.La), B = Zj(A); fk(B, d); var D = { prefix: x, domain: y, Kb: w, flags: z }; if (p) {
            var F = q(E.ia) || {}; if (v) {
                var K = q(E.qb), P = void 0 === K ? !0 : !!K; rg(F[E.Za],
                    !!F[E.H]) && Jg(ck, D); Gg(D); Lg(["aw", "dc"], D);
            } q(E.Ca) && Ng(); F[E.H] && Kg(ck, F[E.H], F[E.ab], !!F[E.$a], x); oh(l, d); Xj({ pd: !1, qa: u, R: a, eventId: d.eventId, nc: v ? D : void 0, yc: v })
        } if (b === E.Ia) { var S = q(E.Aa), W = q(E.za), ja = q(S); if (S === E.Vb && void 0 === ja) { var O = Tg("aw", D.prefix, u); 0 === O.length ? W(void 0) : 1 === O.length ? W(O[0]) : W(O) } else W(ja) } else {
            var J = !1 === q(E.he) || !1 === q(E.tb); if (!p || !t && !J) if (!0 === q(E.ie) &&
                (t = !1), !1 !== q(E.da) || t) {
                    var L = { google_conversion_id: r, google_remarketing_only: !t, onload_callback: d.onSuccess, gtm_onFailure: d.onFailure, google_conversion_format: "3", google_conversion_color: "ffffff", google_conversion_domain: "", google_conversion_label: n, google_conversion_language: q(E.Ya), google_conversion_value: q(E.Da), google_conversion_currency: q(E.ya), google_conversion_order_id: q(E.vb), google_user_id: q(E.wb), google_conversion_page_url: q(E.sb), google_conversion_referrer_url: q(E.Ba), google_gtm: qj() };
                L.google_gtm_experiments = { capi: !0 }; t && (L.google_transport_url = $i(A, "/")); L.google_restricted_data_processing = q(E.ad); bh() && (L.opt_image_generator = function () { return new Image }, L.google_enable_display_cookie_match = !1); !1 === q(E.da) && (L.google_allow_ad_personalization_signals = !1); L.google_read_gcl_cookie_opt_out = !v; v && x && (L.google_gcl_cookie_prefix = x); var X = function () {
                    var R = { event: b }, ka = d.eventModel; if (!ka) return null;
                    C(ka, R); for (var Ca = 0; Ca < E.Wd.length; ++Ca)delete R[E.Wd[Ca]]; return R
                }(); X && (L.google_custom_params = X); !t && q(E.U) && (L.google_gtag_event_data = { items: q(E.U) }); if (t && b == E.ka) {
                    L.google_conversion_merchant_id = q(E.ne); L.google_basket_feed_country = q(E.ke); L.google_basket_feed_language = q(E.me); L.google_basket_discount = q(E.je); L.google_basket_transaction_type = b; L.google_disable_merchant_reported_conversions = !0 === q(E.se); bh() && (L.google_disable_merchant_reported_conversions = !0); var ha = gk(q(E.U)); ha && (L.google_conversion_items =
                        ha)
                } var V = function (R, ka) { void 0 != ka && "" !== ka && (L.google_additional_conversion_params = L.google_additional_conversion_params || {}, L.google_additional_conversion_params[R] = ka) }, wa = function (R, ka) { void 0 != ka && "" !== ka && (L.google_additional_params = L.google_additional_params || {}, L.google_additional_params[R] = ka) }; "1" === jg(!1)._up && V("gtm_up", "1"); t && (V("vdnc", q(E.ze)), V("vdltv", q(E.pe))); e(); var la = sh(); 0 === la ? wa("dg", "c") : 1 === la && wa("dg", "e"); L.google_gtm_url_processor = k(); (function () {
                    Hd() ? Rd(function () {
                        e();
                        var R = Pd(E.B); if (t) V("gcs", Qd()), R || A || !u || (L.google_transport_url = "https://pagead2.googlesyndication.com/"), h(R); else if (R) { h(R); return } R || Kd(function (ka) { var Ca = ka.af; L = C(L); L.google_gtm_url_processor = k(Ca); !A && L.google_transport_url && delete L.google_transport_url; e(); t && (V("gcs", Qd()), V("gcu", "1")); h(!0) }, E.B)
                    }, [E.B]) : h(!0)
                })()
            }
        }
    };
    var ik = function (a) { return !(void 0 === a || null === a || 0 === (a + "").length) }, jk = function (a, b) { var c; if (2 === b.aa) return a("ord", Da(1E11, 1E13)), !0; if (3 === b.aa) return a("ord", "1"), a("num", Da(1E11, 1E13)), !0; if (4 === b.aa) return ik(b.sessionId) && a("ord", b.sessionId), !0; if (5 === b.aa) c = "1"; else if (6 === b.aa) c = b.Md; else return !1; ik(c) && a("qty", c); ik(b.oc) && a("cost", b.oc); ik(b.transactionId) && a("ord", b.transactionId); return !0 }, lk = function (a, b, c) {
        function d(w, z, A) {
            r.hasOwnProperty(w) || (z = String(z), p.push(";" + w + "=" + (A ?
                z : kk(z))))
        } var e = a.rd, f = a.Pd, h = a.protocol; h += f ? "//" + e + ".fls.doubleclick.net/activityi" : "//ad.doubleclick.net/activity"; var k = ";", l = !Pd(E.B) && a.qa; l && (h = "https://ade.googlesyndication.com/ddm/activity", k = "/", f = !1); var p = [k, "src=" + kk(e), ";type=" + kk(a.ud), ";cat=" + kk(a.Cb)], r = a.gh || {}; Ia(r, function (w, z) { p.push(";" + kk(w) + "=" + kk(z + "")) }); if (jk(d, a)) {
            ik(a.Kc) && d("u", a.Kc); ik(a.Jc) && d("tran", a.Jc); d("gtm", qj()); Hd() && (d("gcs", Qd()), c && d("gcu", "1")); (function (w, z) {
                z &&
                d(w, z)
            })("gdpr_consent", Tj()); "1" === jg(!1)._up && d("gtm_up", "1"); !1 === a.Lg && d("npa", "1"); if (a.qd) { var n = void 0 === a.qa ? !0 : !!a.qa, t = Tg("dc", a.eb, n); t && t.length && d("gcldc", t.join(".")); var q = Tg("aw", a.eb, n); q && q.length && d("gclaw", q.join(".")); var u = Ug(n); u && d("gac", u); Of({ prefix: a.eb, Kb: a.dh, domain: a.bh, flags: a.zi }); var v = Jf[Kf(a.eb)]; v && d("auiddc", v) } ik(a.Hd) && d("prd", a.Hd, !0); Ia(a.Td, function (w, z) { d(w, z) }); p.push(b || ""); if (ik(a.Ac)) {
                var x = a.Ac || ""; l && (x = me(x));
                d("~oref", x)
            } var y = h + p.join("") + "?"; f ? ld(y, a.onSuccess) : md(y, a.onSuccess, a.onFailure)
        } else I(a.onFailure)
    }, kk = encodeURIComponent, mk = function (a, b) { Hd() ? Rd(function () { lk(a, b); Pd(E.B) || Kd(function () { lk(a, b, !0) }, E.B) }, [E.B]) : lk(a, b) };
    var nk = function (a, b, c, d) { function e() { var f = { config: a, gtm: qj() }; c && (Of(d), f.auiddc = Jf[Kf(d.prefix)]); b && (f.loadInsecure = b); void 0 === G.__dc_ns_processor && (G.__dc_ns_processor = []); G.__dc_ns_processor.push(f); jd((b ? "http" : "https") + "://www.googletagmanager.com/dclk/ns/v1.js") } Pd(E.B) ? e() : Kd(e, E.B) }, ok = function (a) {
        var b = /^u([1-9]\d?|100)$/, c = a.getWithConfig(E.qe) || {}, d = mj(a), e = {}, f = {}; if (gb(c)) for (var h in c) if (c.hasOwnProperty(h) && b.test(h)) { var k = c[h]; g(k) && (e[h] = k) } for (var l = 0; l < d.length; l++) {
            var p =
                d[l]; b.test(p) && (e[p] = p)
        } for (var r in e) e.hasOwnProperty(r) && (f[r] = a.getWithConfig(e[r])); return f
    }, pk = function (a) { function b(l, p, r) { void 0 !== r && 0 !== (r + "").length && d.push(l + p + ":" + c(r + "")) } var c = encodeURIComponent, d = [], e = a(E.U) || []; if (Aa(e)) for (var f = 0; f < e.length; f++) { var h = e[f], k = f + 1; b("i", k, h.id); b("p", k, h.price); b("q", k, h.quantity); b("c", k, a(E.oe)); b("l", k, a(E.Ya)) } return d.join("|") }, qk = function (a) {
        var b = /^DC-(\d+)(\/([\w-]+)\/([\w-]+)\+(\w+))?$/.exec(a); if (b) {
            var c = {
                standard: 2, unique: 3, per_session: 4,
                transactions: 5, items_sold: 6, "": 1
            }[(b[5] || "").toLowerCase()]; if (c) return { containerId: "DC-" + b[1], R: b[3] ? a : "", Fg: b[1], Eg: b[3] || "", Cb: b[4] || "", aa: c }
        }
    }, tk = function (a, b, c, d) {
        var e = qk(a); if (e) {
            var f = function (J) { return d.getWithConfig(J) }, h = !1 !== f(E.pb), k = f(E.ob) || f(E.X), l = f(E.V), p = f(E.fa), r = f(E.la), n = f(E.$f), t = void 0 != f(E.M) && !1 !== f(E.M), q = 3 === ch(); if (b === E.Ia) { var u = f(E.Aa), v = f(E.za), x = f(u); if (u === E.Vb && void 0 === x) { var y = Tg("dc", k, t); 0 === y.length ? v(void 0) : 1 === y.length ? v(y[0]) : v(y) } else v(x) } else if (b ===
                E.ca) { var w = { prefix: k, domain: l, Kb: p, flags: r }, z = f(E.ia) || {}, A = f(E.qb), B = void 0 === A ? !0 : !!A; h && (rg(z[E.Za], !!z[E.H]) && Jg(rk, w), Gg(w), Lg(rk, w), sk ? Vg(B, w) : Wg(B, w)); z[E.H] && Kg(rk, z[E.H], z[E.ab], !!z[E.$a], k); f(E.Ca) && Ng(); if (n && n.exclusion_parameters && n.engines) if (bh()) { } else nk(n, q, h, w); Xj({ pd: !0, qa: t, R: a, eventId: d.eventId, nc: h ? w : void 0, yc: h }); I(d.onSuccess) } else {
                    var D = {}, F = f(E.Zf); if (gb(F)) for (var K in F) if (F.hasOwnProperty(K)) {
                        var P =
                            F[K]; void 0 !== P && null !== P && (D[K] = P)
                    } var S = ""; if (5 === e.aa || 6 === e.aa) S = pk(f); var W = ok(d), ja = !0 === f(E.Wf); if (bh() && ja) { ja = !1 } var O = {
                        Cb: e.Cb, qd: h, bh: l, dh: p, eb: k, oc: f(E.Da), aa: e.aa, gh: D, rd: e.Fg, ud: e.Eg, onFailure: d.onFailure, onSuccess: d.onSuccess, Ac: ke(le(G.location.href)), Hd: S, protocol: q ? "http:" : "https:", Md: f(E.lg), Pd: ja, sessionId: f(E.$b), Jc: void 0, transactionId: f(E.vb), Kc: void 0, Td: W, Lg: !1 !== f(E.da), eventId: d.eventId,
                        qa: t
                    }; mk(O)
            }
        } else I(d.onFailure)
    }, rk = ["aw", "dc"], sk = !1;
    var vk = function (a) { function b() { var d = c, e = uk(JSON.stringify(a[d])), f = "https://www.google.com/travel/flights/click/conversion/" + uk(a.conversion_id) + "/?" + d + "=" + e; if (a.conversionLinkerEnabled) { var h = Tg("gf", a.cookiePrefix, void 0); if (h && h.length) for (var k = 0; k < h.length; k++)f += "&gclgf=" + uk(h[k]) } md(f, a.onSuccess, a.onFailure) } var c; if (a.hasOwnProperty("conversion_data")) c = "conversion_data"; else if (a.hasOwnProperty("price")) c = "price"; else return; Pd(E.B) ? b() : Kd(b, E.B) }, uk = function (a) {
        return null === a || void 0 ===
            a || 0 === String(a).length ? "" : encodeURIComponent(String(a))
    };
    var wk = /.*\.google\.com(:\d+)?\/(?:booking|travel)\/flights.*/, yk = function (a, b, c, d) {
        var e = function (D) { return d.getWithConfig(D) }, f = Zg(a).F[0], h = !1 !== e(E.pb), k = e(E.ob) || e(E.X), l = e(E.V), p = e(E.fa), r = e(E.la); if (b === E.Ia) { var n = e(E.Aa), t = e(E.za), q = e(n); if (n === E.Vb && void 0 === q) { var u = void 0 != e(E.M) && !1 !== e(E.M), v = Tg("gf", k, u); 0 === v.length ? t(void 0) : 1 === v.length ? t(v[0]) : t(v) } else t(q) } else if (b === E.ca) { if (h) { var x = { prefix: k, domain: l, flags: r, Kb: p }; Gg(x); Lg(["aw", "dc"], x) } I(d.onSuccess) } else {
            var y = {
                conversion_id: f,
                onFailure: d.onFailure, onSuccess: d.onSuccess, conversionLinkerEnabled: h, cookiePrefix: k
            }, w = wk.test(G.location.href); if (b === E.xa) { var z = { partner_id: f, is_direct_booking: w, total_price: e(E.Da), currency: e(E.ya) }; y.price = z; vk(y); return } if (b !== E.ka) I(d.onFailure); else {
                var A = { partner_id: f, trip_type: e(E.qg), total_price: e(E.Da), currency: e(E.ya), is_direct_booking: w, flight_segment: xk(e(E.U)) }, B =
                    e(E.ig); B && "object" === typeof B && (A.passengers_total = Ka(B.total), A.passengers_adult = Ka(B.adult), A.passengers_child = Ka(B.child), A.passengers_infant_in_seat = Ka(B.infant_in_seat), A.passengers_infant_in_lap = Ka(B.infant_in_lap)); y.conversion_data = A; vk(y)
            }
        }
    }, xk = function (a) {
        if (a) {
            for (var b = [], c = 0, d = 0; d < a.length; ++d) {
                var e = a[d]; !e || void 0 !== e.category && "" !== e.category && "FlightSegment" !== e.category || (b[c] = {
                    cabin: e.travel_class, fare_product: e.fare_product, booking_code: e.booking_code, flight_number: e.flight_number,
                    origin: e.origin, destination: e.destination, departure_date: e.start_date
                }, c++)
            } return b
        }
    };
    var Dk = function (a, b, c, d) {
        function e() { Tj() && (A += "&gdpr_consent=" + encodeURIComponent(Tj())); if (k) { var F = b === E.xa ? Tg("aw", l, void 0) : Tg("ha", l, void 0); A += F.map(function (K) { return "&gclha=" + encodeURIComponent(K) }).join("") } md(A, d.onSuccess, d.onFailure) } var f = Zg(a), h = function (F) { return d.getWithConfig(F) }, k = !1 !== h(E.pb), l = h(E.ob) || h(E.X), p = h(E.V), r = h(E.fa), n = h(E.la); if (b === E.Ia) {
            var t = h(E.Aa), q = h(E.za), u = h(t); if (t === E.Vb &&
                void 0 === u) { var v = void 0 != h(E.M) && !1 !== h(E.M), x = Tg("ha", l, v); 0 === x.length ? q(void 0) : 1 === x.length ? q(x[0]) : q(x) } else q(u)
        } else if (b === E.ca) { var y = h(E.ia) || {}; if (k) { var w = { prefix: l, domain: p, flags: n, Kb: r }; rg(y[E.Za], !!y[E.H]) && Jg(zk, w); Gg(w); Lg(["aw", "dc"], w) } y[E.H] && Kg(zk, y[E.H], y[E.ab], !!y[E.$a], l); I(d.onSuccess) } else {
            var z = f.F[0]; if (/^\d+$/.test(z)) {
                var A = "https://www.googletraveladservices.com/travel/clk/pagead/conversion/" + encodeURIComponent(z) + "/"; if (b === E.ka) {
                    var B = Ak(h(E.vb), h(E.Da), h(E.ya), h(E.U));
                    B = encodeURIComponent(Bk(B)); A += "?data=" + B
                } else if (b === E.xa) { var D = Ck(z, h(E.Da), h(E.we), h(E.ya), h(E.U)); D = encodeURIComponent(Bk(D)); A += "?label=FH&guid=ON&script=0&ord=" + Da(0, 4294967295) + ("&price=" + D) } else { I(d.onFailure); return } Pd(E.B) ? e() : Kd(e, E.B)
            } else I(d.onFailure)
        }
    }, Ak = function (a, b, c, d) {
        var e = {}; Ek(a) && (e.hct_booking_xref = a); g(c) && (e.hct_currency_code = c); Ek(b) && (e.hct_total_price = b, e.hct_base_price = b); if (!Aa(d) || 0 === d.length) return e; var f = d[0]; if (!gb(f)) return e; Ek(f[Fk.hd]) && (e.hct_partner_hotel_id =
            f[Fk.hd]); g(f[Fk.kd]) && (e.hct_checkin_date = f[Fk.kd]); g(f[Fk.Nc]) && (e.hct_checkout_date = f[Fk.Nc]); return e
    }, Ck = function (a, b, c, d, e) {
        function f(r) { void 0 === r && (r = 0); if (Ek(r)) return l + r } function h(r, n, t) { t(n) && (k[r] = n) } var k = {}; k.partner_id = a; var l = "USD"; g(d) && (l = k.currency = d); Ek(b) && (k.base_price_value_string = f(b), k.display_price_value_string = f(b)); Ek(c) && (k.tax_price_value_string = f(c)); g("LANDING_PAGE") && (k.page_type = "LANDING_PAGE"); if (!Aa(e) || 0 == e.length) return k; var p = e[0]; if (!gb(p)) return k; Ek(p[Fk.Re]) &&
            (k.total_price_value_string = f(p[Fk.Re])); h("partner_hotel_id", p[Fk.hd], Ek); h("check_in_date", p[Fk.kd], g); h("check_out_date", p[Fk.Nc], g); h("adults", p[Fk.zg], Gk); h(Fk.Te, p[Fk.Te], g); h(Fk.Se, p[Fk.Se], g); return k
    }, Bk = function (a) { var b = []; Ia(a, function (c, d) { b.push(c + "=" + d) }); return b.join(";") }, Ek = function (a) { return g(a) || Gk(a) }, Gk = function (a) { return "number" === typeof a }, Fk = { hd: "id", Re: "price", kd: "start_date", Nc: "end_date", zg: "occupancy", Te: "room_id", Se: "rate_rule_id" }, zk = ["ha"]; var Ik = function () { var a = !0; Uj(7) && Uj(9) && Uj(10) || (a = !1); var b = !0; b = !1; b && !Hk() && (a = !1); return a }, Hk = function () { var a = !0; Uj(3) && Uj(4) || (a = !1); return a };
    var Mk = function (a, b) { var c = b.getWithConfig(E.Aa), d = b.getWithConfig(E.za), e = b.getWithConfig(c); if (void 0 === e) { var f = void 0; Jk.hasOwnProperty(c) ? f = Jk[c] : Kk.hasOwnProperty(c) && (f = Kk[c]); 1 === f && (f = Lk(c)); g(f) ? bi()(function () { var h = bi().getByName(a).get(f); d(h) }) : d(void 0) } else d(e) }, Pk = function (a, b, c) { if (Hd()) { var d = function () { var e = bi(), f = Nk(a, b, "", c); Ok(b, f.Ea) && (e(function () { e.remove(b) }), e("create", a, f.Ea)) }; Kd(d, E.I); Kd(d, E.B) } }, Wk = function (a, b, c) {
        var d = "https://www.google-analytics.com/analytics.js",
        e = di(); if (ya(e)) {
            var f = "gtag_" + a.split("-").join("_"), h = function (w) { var z = [].slice.call(arguments, 0); z[0] = f + "." + z[0]; e.apply(window, z) }, k = function () { var w = function (D, F) { for (var K = 0; F && K < F.length; K++)h(D, F[K]) }, z = Qk(b, c); if (z) { var A = z.action; if ("impressions" === A) w("ec:addImpression", z.vh); else if ("promo_click" === A || "promo_view" === A) { var B = z.Jd; w("ec:addPromo", z.Jd); B && 0 < B.length && "promo_click" === A && h("ec:setAction", A) } else w("ec:addProduct", z.hb), h("ec:setAction", A, z.Bb) } }, l = function () { if (bh()) { } else { var w = c.getWithConfig(E.hg); w && (h("require", w, { dataLayer: "dataLayer" }), h("require", "render")) } }, p = Nk(a, f, b, c), r = function (w, z, A) { A && (z = "" + z); p.Fa[w] = z }; Ok(f, p.Ea) && (e(function () { bi() && bi().remove(f) }), Rk[f] = !1); e("create", a, p.Ea); if (p.Ea._x_19) { var n = aj(p.Ea._x_19, "/analytics.js"); n && (d = n); p.Ea._x_20 && !Rk[f] && (Rk[f] = !0, e(ii(f, p.Ea._x_20))) } (function () {
                var w = c.getWithConfig("custom_map"); e(function () {
                    if (gb(w)) {
                        var z = p.Fa, A = bi().getByName(f), B; for (B in w) if (w.hasOwnProperty(B) &&
                            /^(dimension|metric)\d+$/.test(B) && void 0 != w[B]) { var D = A.get(Lk(w[B])); Sk(z, B, D) }
                    }
                })
            })(); (function (w) { if (w) { var z = {}; if (gb(w)) for (var A in Tk) Tk.hasOwnProperty(A) && Uk(Tk[A], A, w[A], z); h("require", "linkid", z) } })(p.linkAttribution); var t = p[E.ia]; if (t && t[E.H]) { var q = t[E.ab]; ei(f + ".", t[E.H], void 0 === q ? !!t.use_anchor : "fragment" === q, !!t[E.$a]) } b === E.Pc ? (l(), h("send", "pageview", p.Fa)) : b === E.ca ? (l(), oh(a, c), c.getWithConfig(E.Ca) && (Ng(), fi(f + ".")), 0 != p.sendPageView && h("send", "pageview", p.Fa), Pk(a, f, c)) : b ===
                E.Ia ? Mk(f, c) : "screen_view" === b ? h("send", "screenview", p.Fa) : "timing_complete" === b ? (r("timingCategory", p.eventCategory, !0), r("timingVar", p.name, !0), r("timingValue", Ka(p.value)), void 0 !== p.eventLabel && r("timingLabel", p.eventLabel, !0), h("send", "timing", p.Fa)) : "exception" === b ? h("send", "exception", p.Fa) : "optimize.callback" !== b && (0 <= m([E.Ub, "select_content", E.xa, E.Ua, E.Va, E.Ha, "set_checkout_option", E.ka, E.Wa, "view_promotion", "checkout_progress"], b) && (h("require", "ec", "ec.js"), k()), r("eventCategory", p.eventCategory,
                    !0), r("eventAction", p.eventAction || b, !0), void 0 !== p.eventLabel && r("eventLabel", p.eventLabel, !0), void 0 !== p.value && r("eventValue", Ka(p.value)), h("send", "event", p.Fa)); var u = !1; var v = Vk; u && (v = c.getContainerTypeLoaded("UA")); if (!v) {
                        Vk = !0; Xh(); var x = function () { u && c.setContainerTypeLoaded("UA", !1); c.onFailure() }, y = function () {
                            u && c.setContainerTypeLoaded("UA",
                                !0); bi().loaded || x()
                        }; bh() ? I(y) : jd(d, y, x)
                    }
        } else I(c.onFailure)
    }, Xk = function (a, b, c, d) { Rd(function () { Wk(a, b, d) }, [E.I, E.B]) }, Yk = function (a) { return Pd(a) }, Vk, Rk = {}, Jk = { client_id: 1, client_storage: "storage", cookie_name: 1, cookie_domain: 1, cookie_expires: 1, cookie_path: 1, cookie_update: 1, cookie_flags: 1, sample_rate: 1, site_speed_sample_rate: 1, use_amp_client_id: 1, store_gac: 1, conversion_linker: "storeGac" }, Kk = {
        anonymize_ip: 1, app_id: 1, app_installer_id: 1, app_name: 1, app_version: 1, campaign: {
            name: "campaignName", source: "campaignSource",
            medium: "campaignMedium", term: "campaignKeyword", content: "campaignContent", id: "campaignId"
        }, currency: "currencyCode", description: "exDescription", fatal: "exFatal", language: 1, non_interaction: 1, page_hostname: "hostname", page_referrer: "referrer", page_path: "page", page_location: "location", page_title: "title", screen_name: 1, transport_type: "transport", user_id: 1
    }, Zk = { content_id: 1, event_category: 1, event_action: 1, event_label: 1, link_attribution: 1, linker: 1, method: 1, name: 1, send_page_view: 1, value: 1 }, Tk = {
        cookie_name: 1,
        cookie_expires: "duration", levels: 1
    }, $k = { anonymize_ip: 1, fatal: 1, non_interaction: 1, use_amp_client_id: 1, send_page_view: 1, store_gac: 1, conversion_linker: 1 }, Uk = function (a, b, c, d) { if (void 0 !== c) if ($k[b] && (c = Ma(c)), "anonymize_ip" !== b || c || (c = void 0), 1 === a) d[Lk(b)] = c; else if (g(a)) d[a] = c; else for (var e in a) a.hasOwnProperty(e) && void 0 !== c[e] && (d[a[e]] = c[e]) }, Lk = function (a) { return a && g(a) ? a.replace(/(_[a-z])/g, function (b) { return b[1].toUpperCase() }) : a }, al = function (a) {
        var b = "general"; 0 <= m([E.be, E.Ua, E.ee, E.Ha,
            "checkout_progress", E.ka, E.Wa, E.Va, "set_checkout_option"], a) ? b = "ecommerce" : 0 <= m("generate_lead login search select_content share sign_up view_item view_item_list view_promotion view_search_results".split(" "), a) ? b = "engagement" : "exception" === a && (b = "error"); return b
    }, Sk = function (a, b, c) { a.hasOwnProperty(b) || (a[b] = c) }, bl = function (a) {
        if (Aa(a)) {
            for (var b = [], c = 0; c < a.length; c++) { var d = a[c]; if (void 0 != d) { var e = d.id, f = d.variant; void 0 != e && void 0 != f && b.push(String(e) + "." + String(f)) } } return 0 < b.length ? b.join("!") :
                void 0
        }
    }, Nk = function (a, b, c, d) {
        function e(F, K) { void 0 !== K && (k[F] = K) } var f = function (F) { return d.getWithConfig(F) }, h = {}, k = {}, l = {}, p = bl(f(E.dg)); p && Sk(k, "exp", p); Hd() && (l._cs = Yk); var r = f("custom_map"); if (gb(r)) for (var n in r) if (r.hasOwnProperty(n) && /^(dimension|metric)\d+$/.test(n) && void 0 != r[n]) { var t = f(String(r[n])); void 0 !== t && Sk(k, n, t) } for (var q = mj(d), u = 0; u < q.length; ++u) {
            var v = q[u], x = f(v); if (Zk.hasOwnProperty(v)) Uk(Zk[v], v, x, h); else if (Kk.hasOwnProperty(v)) Uk(Kk[v], v, x, k); else if (Jk.hasOwnProperty(v)) Uk(Jk[v],
                v, x, l); else if (/^(dimension|metric|content_group)\d+$/.test(v)) Uk(1, v, x, k); else if ("developer_id" === v) { var y = $a(x); y && (k["&did"] = y) } else v === E.X && 0 > m(q, E.Wb) && (l.cookieName = x + "_ga")
        } Sk(l, "cookieDomain", "auto"); Sk(k, "forceSSL", !0); Sk(h, "eventCategory", al(c)); 0 <= m(["view_item", "view_item_list", "view_promotion", "view_search_results"], c) && Sk(k, "nonInteraction", !0); "login" === c || "sign_up" === c || "share" === c ? Sk(h, "eventLabel", f(E.gg)) : "search" === c || "view_search_results" === c ? Sk(h, "eventLabel", f(E.og)) : "select_content" ===
            c && Sk(h, "eventLabel", f(E.Yf)); var w = h[E.ia] || {}, z = w[E.Za]; z || 0 != z && w[E.H] ? l.allowLinker = !0 : !1 === z && Sk(l, "useAmpClientId", !1); f(E.Ca) && (l._useUp = !0); !1 !== f(E.Xf) && !1 !== f(E.nb) && Ik() || (k.allowAdFeatures = !1); if (!1 === f(E.da) || !Hk()) { var A = "allowAdFeatures"; A = "allowAdPersonalizationSignals"; k[A] = !1 } l.name = b; k["&gtm"] = qj(!0); k.hitCallback = d.onSuccess; Hd() && (k["&gcs"] = Qd(), Pd(E.I) || (l.storage = "none"), Pd(E.B) || (k.allowAdFeatures = !1, l.storeGac = !1)); var B = f(E.La) || f(E.fg) || af("gtag.remote_config." + a + ".url", 2), D = f(E.eg) || af("gtag.remote_config." + a + ".dualId", 2); if (B && null != bd) { l._x_19 = B; } D && (l._x_20 = D); h.Fa = k; h.Ea = l; return h
    }, Qk = function (a, b) {
        function c(v) {
            function x(w,
                z) { for (var A = 0; A < z.length; A++) { var B = z[A]; if (v[B]) { y[w] = v[B]; break } } } var y = C(v);
            x("listPosition", ["list_position"]); x("creative", ["creative_name"]); x("list", ["list_name"]); x("position", ["list_position", "creative_slot"]); return y
        } function d(v) { for (var x = [], y = 0; v && y < v.length; y++)v[y] && x.push(c(v[y])); return x.length ? x : void 0 } function e(v) { return { id: f(E.vb), affiliation: f(E.ag), revenue: f(E.Da), tax: f(E.we), shipping: f(E.ve), coupon: f(E.bg), list: f(E.Sc) || v } } for (var f = function (v) { return b.getWithConfig(v) }, h = f(E.U), k, l = 0; h && l < h.length && !(k = h[l][E.Sc]); l++); var p = f("custom_map"); if (gb(p)) for (var r =
            0; h && r < h.length; ++r) { var n = h[r], t; for (t in p) p.hasOwnProperty(t) && /^(dimension|metric)\d+$/.test(t) && void 0 != p[t] && Sk(n, t, n[p[t]]) } var q = null, u = f(E.cg); a === E.ka || a === E.Wa ? q = { action: a, Bb: e(), hb: d(h) } : a === E.Ua ? q = { action: "add", hb: d(h) } : a === E.Va ? q = { action: "remove", hb: d(h) } : a === E.xa ? q = { action: "detail", Bb: e(k), hb: d(h) } : a === E.Ub ? q = { action: "impressions", vh: d(h) } : "view_promotion" === a ? q = { action: "promo_view", Jd: d(u) } : "select_content" === a && u && 0 < u.length ? q = { action: "promo_click", Jd: d(u) } : "select_content" === a ? q =
                { action: "click", Bb: { list: f(E.Sc) || k }, hb: d(h) } : a === E.Ha || "checkout_progress" === a ? q = { action: "checkout", hb: d(h), Bb: { step: a === E.Ha ? 1 : f(E.ue), option: f(E.te) } } : "set_checkout_option" === a && (q = { action: "checkout_option", Bb: { step: f(E.ue), option: f(E.te) } }); q && (q.Ai = f(E.ya)); return q
    }, cl = {}, Ok = function (a, b) { var c = cl[a]; cl[a] = C(b); if (!c) return !1; for (var d in b) if (b.hasOwnProperty(d) && b[d] !== c[d]) return !0; for (var e in c) if (c.hasOwnProperty(e) && c[e] !== b[e]) return !0; return !1 }; var dl = !1; function el() { var a = M; return a.gcq = a.gcq || new fl }
    var gl = function (a, b, c) { el().register(a, b, c) }, hl = function (a, b, c, d) { el().push("event", [b, a], c, d) }, il = function (a, b) { el().push("config", [a], b) }, jl = function (a, b, c, d) { el().push("get", [a, b], c, d) }, kl = {}, ll = function () { this.status = 1; this.containerConfig = {}; this.targetConfig = {}; this.remoteConfig = {}; this.o = null; this.m = !1 }, ml = function (a, b, c, d, e) { this.type = a; this.C = b; this.R = c || ""; this.m = d; this.o = e }, fl = function () { this.K = {}; this.o = {}; this.m = []; this.C = { AW: !1, UA: !1 } }, nl = function (a, b) {
        var c = Zg(b); return a.K[c.containerId] =
            a.K[c.containerId] || new ll
    }, ol = function (a, b, c) {
        if (b) {
            var d = Zg(b); if (d && 1 === nl(a, b).status) {
                nl(a, b).status = 2; var e = {}; Gi && (e.timeoutId = G.setTimeout(function () { Dc(38); si() }, 3E3)); a.push("require", [e], d.containerId); kl[d.containerId] = Pa(); if (bh()) { } else {
                    var h =
                        "/gtag/js?id=" + encodeURIComponent(d.containerId) + "&l=dataLayer&cx=c", k = ("http:" != G.location.protocol ? "https:" : "http:") + ("//www.googletagmanager.com" + h), l = aj(c, h) || k; jd(l)
                }
            }
        }
    }, pl = function (a, b, c, d) {
        if (d.R) {
            var e = nl(a, d.R), f = e.o; if (f) {
                var h = C(c), k = C(e.targetConfig[d.R]), l = C(e.containerConfig), p = C(e.remoteConfig), r = C(a.o), n = af("gtm.uniqueEventId"), t = Zg(d.R).prefix, q = kj(jj(lj(ij(hj(gj(fj(ej(dj(h), k), l), p), r), function () { Ji(n, t, "2"); }), function () {
                    Ji(n, t, "3");
                }), function (u, v) { a.C[u] = v }), function (u) { return a.C[u] }); try { Ji(n, t, "1"); f(d.R, b, d.C, q) } catch (u) { Ji(n, t, "4"); }
            }
        }
    }; aa = fl.prototype;
    aa.register = function (a, b, c) {
        var d = nl(this, a); if (3 !== d.status) {
            d.o = b; d.status = 3; if (c) { d.remoteConfig = c } var e = Zg(a), f = kl[e.containerId]; if (void 0 !== f) {
                var h = M[e.containerId].bootstrap, k = e.prefix.toUpperCase(); M[e.containerId]._spx && (k = k.toLowerCase()); var l = af("gtm.uniqueEventId"), p = k, r = Pa() - h; if (Gi && !xi[l]) {
                    l !== ti && (pi(), ti = l); var n = p + "." + Math.floor(h - f) +
                        "." + Math.floor(r); Bi = Bi ? Bi + "," + n : "&cl=" + n
                } delete kl[e.containerId]
            } this.flush()
        }
    }; aa.push = function (a, b, c, d) { var e = Math.floor(Pa() / 1E3); ol(this, c, b[0][E.La] || this.o[E.La]); dl && c && nl(this, c).m && (d = !1); this.m.push(new ml(a, e, c, b, d)); d || this.flush() }; aa.insert = function (a, b, c) { var d = Math.floor(Pa() / 1E3); 0 < this.m.length ? this.m.splice(1, 0, new ml(a, d, c, b, !1)) : this.m.push(new ml(a, d, c, b, !1)) };
    aa.flush = function (a) {
        for (var b = this, c = [], d = !1; this.m.length;) {
            var e = this.m[0]; if (e.o) dl ? !e.R || nl(this, e.R).m ? (e.o = !1, this.m.push(e)) : c.push(e) : (e.o = !1, this.m.push(e)); else switch (e.type) {
                case "require": if (3 !== nl(this, e.R).status && !a) { dl && this.m.push.apply(this.m, c); return } Gi && G.clearTimeout(e.m[0].timeoutId); break; case "set": Ia(e.m[0], function (t, q) { C(Za(t, q), b.o) }); break; case "config": var f = e.m[0], h = !!f[E.ac]; delete f[E.ac]; var k = nl(this, e.R), l = Zg(e.R), p = l.containerId === l.id; h || (p ? k.containerConfig =
                    {} : k.targetConfig[e.R] = {}); k.m && h || pl(this, E.ca, f, e); k.m = !0; delete f[E.xb]; p ? C(f, k.containerConfig) : C(f, k.targetConfig[e.R]); dl && (d = !0); break; case "event": pl(this, e.m[1], e.m[0], e); break; case "get": var r = {}, n = (r[E.Aa] = e.m[0], r[E.za] = e.m[1], r); pl(this, E.Ia, n, e)
            }this.m.shift()
        } dl && (this.m.push.apply(this.m, c), d && this.flush())
    }; aa.getRemoteConfig = function (a) { return nl(this, a).remoteConfig }; var ql = function (a, b, c) {
        function d(f, h) { var k = f[h]; k = ud(f, h); return k } var e = { event: b, "gtm.element": a, "gtm.elementClasses": d(a, "className"), "gtm.elementId": a["for"] || pd(a, "id") || "", "gtm.elementTarget": a.formTarget || d(a, "target") || "" }; c && (e["gtm.triggers"] = c.join(",")); e["gtm.elementUrl"] = (a.attributes && a.attributes.formaction ? a.formAction : "") || a.action || d(a, "href") || a.src || a.code || a.codebase ||
            ""; return e
    }, rl = function (a) { M.hasOwnProperty("autoEventsSettings") || (M.autoEventsSettings = {}); var b = M.autoEventsSettings; b.hasOwnProperty(a) || (b[a] = {}); return b[a] }, sl = function (a, b, c) { rl(a)[b] = c }, tl = function (a, b, c, d) { var e = rl(a), f = Ra(e, b, d); e[b] = c(f) }, ul = function (a, b, c) { var d = rl(a); return Ra(d, b, c) }; var vl = !!G.MutationObserver, wl = void 0, xl = function (a) { if (!wl) { var b = function () { var c = H.body; if (c) if (vl) (new MutationObserver(function () { for (var e = 0; e < wl.length; e++)I(wl[e]) })).observe(c, { childList: !0, subtree: !0 }); else { var d = !1; nd(c, "DOMNodeInserted", function () { d || (d = !0, I(function () { d = !1; for (var e = 0; e < wl.length; e++)I(wl[e]) })) }) } }; wl = []; H.body ? b() : I(b) } wl.push(a) }; var zl = !1, Al = []; function Bl() { if (!zl) { zl = !0; for (var a = 0; a < Al.length; a++)I(Al[a]) } } var Cl = function (a) { zl ? I(a) : Al.push(a) }; var Dl = "HA GF G UA AW DC".split(" "), El = !1, Fl = {}, Gl = !1; function Hl(a, b) { var c = { event: a }; b && (c.eventModel = C(b), b[E.Tc] && (c.eventCallback = b[E.Tc]), b[E.Xb] && (c.eventTimeout = b[E.Xb])); return c } function Il() { El = El || !M.gtagRegistered, M.gtagRegistered = !0, El && (M.addTargetToGroup = function (a) { Jl(a, "default") }); return El }
    var Kl = function (a) { Ia(Fl, function (b, c) { var d = m(c, a); 0 <= d && c.splice(d, 1) }) }, Jl = function (a, b) { b = b.toString().split(","); for (var c = 0; c < b.length; c++)Fl[b[c]] = Fl[b[c]] || [], Fl[b[c]].push(a) };
    var Ll = {
        config: function (a) { var b; if (2 > a.length || !g(a[1])) return; var c = {}; if (2 < a.length) { if (void 0 != a[2] && !gb(a[2]) || 3 < a.length) return; c = a[2] } var d = Zg(a[1]); if (!d) return; Kl(d.id); Jl(d.id, c[E.Xc] || "default"); delete c[E.Xc]; Gl || Dc(43); Ve(); if (Il() && -1 !== m(Dl, d.prefix)) { "G" === d.prefix && (c[E.xb] = !0); il(c, d.id); return } df("gtag.targets." + d.id, void 0); df("gtag.targets." + d.id, C(c)); var e = {}; e[E.Ka] = d.id; b = Hl(E.ca, e); return b }, consent: function (a) {
            function b() {
                Il() &&
                C(a[2], { subcommand: a[1] })
            } if (3 === a.length) { Dc(39); var c = Ve(), d = a[1]; "default" === d ? (b(), Nd(a[2])) : "update" === d && (b(), Od(a[2], c)) }
        }, event: function (a) {
            var b = a[1]; if (!(2 > a.length) && g(b)) {
                var c; if (2 < a.length) { if (!gb(a[2]) && void 0 != a[2] || 3 < a.length) return; c = a[2] } var d = Hl(b, c); var e; var f = c && c[E.Ka]; void 0 === f && (f = af(E.Ka, 2), void 0 === f && (f = "default")); if (g(f) || Aa(f)) {
                    for (var h = f.toString().replace(/\s+/g, "").split(","), k = [], l = 0; l < h.length; l++)0 <= h[l].indexOf("-") ? k.push(h[l]) :
                        k = k.concat(Fl[h[l]] || []); e = ah(k)
                } else e = void 0; var p = e; if (!p) return; var r = Il(); Ve(); for (var n = [], t = 0; r && t < p.length; t++) { var q = p[t]; if (-1 !== m(Dl, q.prefix)) { var u = C(c); "G" === q.prefix && (u[E.xb] = !0); hl(b, u, q.id) } n.push(q.id) } d.eventModel = d.eventModel || {}; 0 < p.length ? d.eventModel[E.Ka] = n.join() : delete d.eventModel[E.Ka]; Gl || Dc(43); return d
            }
        }, get: function (a) {
            Dc(53); if (4 !== a.length || !g(a[1]) || !g(a[2]) || !ya(a[3])) return; var b = Zg(a[1]), c = String(a[2]),
                d = a[3]; if (!b) return; Gl || Dc(43); if (!Il() || -1 === m(Dl, b.prefix)) return; Ve(); var e = {}; Hh(C((e[E.Aa] = c, e[E.za] = d, e))); jl(c, function (f) { I(function () { return d(f) }) }, b.id);
        }, js: function (a) { if (2 == a.length && a[1].getTime) return Gl = !0, Il(), { event: "gtm.js", "gtm.start": a[1].getTime() } }, policy: function () { }, set: function (a) {
            var b; 2 == a.length && gb(a[1]) ? b = C(a[1]) : 3 == a.length && g(a[1]) && (b = {}, gb(a[2]) || Aa(a[2]) ? b[a[1]] = C(a[2]) : b[a[1]] = a[2]); if (b) {
                if (Ve(), Il()) {
                    C(b);
                    var c = C(b); el().push("set", [c])
                } b._clear = !0; return b
            }
        }
    }, Ml = { policy: !0 }; var Nl = function (a, b) { var c = a.hide; if (c && void 0 !== c[b] && c.end) { c[b] = !1; var d = !0, e; for (e in c) if (c.hasOwnProperty(e) && !0 === c[e]) { d = !1; break } d && (c.end(), c.end = null) } }, Pl = function (a) { var b = Ol(), c = b && b.hide; c && c.end && (c[a] = !0) }; var hm = function (a) { if (gm(a)) return a; this.m = a }; hm.prototype.sh = function () { return this.m }; var gm = function (a) { return !a || "object" !== eb(a) || gb(a) ? !1 : "getUntrustedUpdateValue" in a }; hm.prototype.getUntrustedUpdateValue = hm.prototype.sh; var im = []; var lm = !1, mm = function (a) { return G["dataLayer"].push(a) }, nm = function (a) { var b = M["dataLayer"], c = b ? b.subscribers : 1, d = 0; return function () { ++d === c && a() } };
    function om(a) { var b = a._clear; Ia(a, function (d, e) { "_clear" !== d && (b && df(d, void 0), df(d, e)) }); Qe || (Qe = a["gtm.start"]); var c = a["gtm.uniqueEventId"]; if (!a.event) return !1; c || (c = Ve(), a["gtm.uniqueEventId"] = c, df("gtm.uniqueEventId", c)); return Zi(a) } function pm() { var a = im[0]; if (null == a || "object" !== typeof a) return !1; if (a.event) return !0; if (Ja(a)) { var b = a[0]; if ("config" === b || "event" === b || "js" === b) return !0 } return !1 }
    function qm() {
        for (var a = !1; !lm && 0 < im.length;) {
            lm = !0; delete Ye.eventModel; $e(); var d = im.shift(); if (null != d) {
                var e = gm(d); if (e) { var f = d; d = gm(f) ? f.getUntrustedUpdateValue() : void 0; for (var h = ["gtm.allowlist", "gtm.blocklist", "gtm.whitelist", "gtm.blacklist", "tagTypeBlacklist"], k = 0; k < h.length; k++) { var l = h[k], p = af(l, 1); if (Aa(p) || gb(p)) p = C(p); Ze[l] = p } } try {
                    if (ya(d)) try { d.call(bf) } catch (y) { } else if (Aa(d)) { var r = d; if (g(r[0])) { var n = r[0].split("."), t = n.pop(), q = r.slice(1), u = af(n.join("."), 2); if (void 0 !== u && null !== u) try { u[t].apply(u, q) } catch (y) { } } } else {
                        if (Ja(d)) {
                            a: {
                                var v =
                                    d; if (v.length && g(v[0])) { var x = Ll[v[0]]; if (x && (!e || !Ml[v[0]])) { d = x(v); break a } } d = void 0
                            } if (!d) { lm = !1; continue }
                        } a = om(d) || a
                    }
                } finally { e && $e(!0) }
            } lm = !1
        } return !a
    } function rm() { var a = qm(); try { Nl(G["dataLayer"], Ie.D) } catch (b) { } return a }
    var tm = function () {
        var a = cd("dataLayer", []), b = cd("google_tag_manager", {}); b = b["dataLayer"] = b["dataLayer"] || {}; Oh(function () { b.gtmDom || (b.gtmDom = !0, a.push({ event: "gtm.dom" })) }); Cl(function () { b.gtmLoad || (b.gtmLoad = !0, a.push({ event: "gtm.load" })) }); b.subscribers = (b.subscribers || 0) + 1; var c = a.push; a.push = function () {
            var e; if (0 < M.SANDBOXED_JS_SEMAPHORE) { e = []; for (var f = 0; f < arguments.length; f++)e[f] = new hm(arguments[f]) } else e = [].slice.call(arguments, 0); var h = c.apply(a, e); im.push.apply(im, e); if (300 <
                this.length) for (Dc(4); 300 < this.length;)this.shift(); var k = "boolean" !== typeof h || h; return qm() && k
        }; var d = a.slice(0); im.push.apply(im, d); sm() && I(rm)
    }, sm = function () { var a = !0; return a }; var um = {}; um.bc = new String("undefined");
    var vm = function (a) { this.m = function (b) { for (var c = [], d = 0; d < a.length; d++)c.push(a[d] === um.bc ? b : a[d]); return c.join("") } }; vm.prototype.toString = function () { return this.m("undefined") }; vm.prototype.valueOf = vm.prototype.toString; um.Dg = vm; um.jd = {}; um.eh = function (a) { return new vm(a) }; var wm = {}; um.Yh = function (a, b) { var c = Ve(); wm[c] = [a, b]; return c }; um.cf = function (a) { var b = a ? 0 : 1; return function (c) { var d = wm[c]; if (d && "function" === typeof d[b]) d[b](); wm[c] = void 0 } }; um.Ah = function (a) {
        for (var b = !1, c = !1, d = 2; d < a.length; d++)b =
            b || 8 === a[d], c = c || 16 === a[d]; return b && c
    }; um.Rh = function (a) { if (a === um.bc) return a; var b = Ve(); um.jd[b] = a; return 'google_tag_manager["' + Ie.D + '"].macro(' + b + ")" }; um.Kh = function (a, b, c) { a instanceof um.Dg && (a = a.m(um.Yh(b, c)), b = xa); return { wd: a, onSuccess: b } }; var xm = ["input", "select", "textarea"], ym = ["button", "hidden", "image", "reset", "submit"], zm = function (a) { var b = a.tagName.toLowerCase(); return !Ba(xm, function (c) { return c === b }) || "input" === b && Ba(ym, function (c) { return c === a.type.toLowerCase() }) ? !1 : !0 }, Am = function (a) { return a.form ? a.form.tagName ? a.form : H.getElementById(a.form) : sd(a, ["form"], 100) }, Bm = function (a, b, c) {
        if (!a.elements) return 0; for (var d = b.getAttribute(c), e = 0, f = 1; e < a.elements.length; e++) {
            var h = a.elements[e]; if (zm(h)) {
                if (h.getAttribute(c) === d) return f;
                f++
            }
        } return 0
    }; var Mm = G.clearTimeout, Nm = G.setTimeout, N = function (a, b, c) { if (bh()) { b && I(b) } else return jd(a, b, c) }, Om = function () { return new Date }, Pm = function () { return G.location.href }, Qm = function (a) { return je(le(a), "fragment") }, Rm = function (a) { return ke(le(a)) }, Sm = function (a, b) { return af(a, b || 2) }, Tm = function (a, b, c) { var d; b ? (a.eventCallback = b, c && (a.eventTimeout = c), d = mm(a)) : d = mm(a); return d }, Um = function (a, b) { G[a] = b }, U = function (a, b, c) {
        b &&
        (void 0 === G[a] || c && !G[a]) && (G[a] = b); return G[a]
    }, Vm = function (a, b, c) { return qf(a, b, void 0 === c ? !0 : !!c) }, Wm = function (a, b, c) { return 0 === zf(a, b, c) }, Xm = function (a, b) { if (bh()) { b && I(b) } else ld(a, b) }, Ym = function (a) { return !!ul(a, "init", !1) }, Zm = function (a) { sl(a, "init", !0) }, $m = function (a, b) { var c = (void 0 === b ? 0 : b) ? "www.googletagmanager.com/gtag/js" : Oe; c += "?id=" + encodeURIComponent(a) + "&l=dataLayer"; N(dh("https://", "http://", c)) }, an = function (a,
        b) { var c = a[b]; c = ud(a, b); return c }, bn = function (a, b, c) { Gi && (hb(a) || Ki(c, b, a)) };
    var cn = um.Kh; function An(a, b) { a = String(a); b = String(b); var c = a.length - b.length; return 0 <= c && a.indexOf(b, c) == c } var Bn = new Ea; function Cn(a, b) { function c(h) { var k = le(h), l = je(k, "protocol"), p = je(k, "host", !0), r = je(k, "port"), n = je(k, "path").toLowerCase().replace(/\/$/, ""); if (void 0 === l || "http" == l && "80" == r || "https" == l && "443" == r) l = "web", r = "default"; return [l, p, r, n] } for (var d = c(String(a)), e = c(String(b)), f = 0; f < d.length; f++)if (d[f] !== e[f]) return !1; return !0 }
    function Dn(a) { return En(a) ? 1 : 0 }
    function En(a) {
        var b = a.arg0, c = a.arg1; if (a.any_of && Aa(c)) { for (var d = 0; d < c.length; d++) { var e = C(a, {}); C({ arg1: c[d], any_of: void 0 }, e); if (Dn(e)) return !0 } return !1 } switch (a["function"]) {
            case "_cn": return 0 <= String(b).indexOf(String(c)); case "_css": var f; a: { if (b) { var h = ["matches", "webkitMatchesSelector", "mozMatchesSelector", "msMatchesSelector", "oMatchesSelector"]; try { for (var k = 0; k < h.length; k++)if (b[h[k]]) { f = b[h[k]](c); break a } } catch (q) { } } f = !1 } return f; case "_ew": return An(b, c); case "_eq": return String(b) ==
                String(c); case "_ge": return Number(b) >= Number(c); case "_gt": return Number(b) > Number(c); case "_lc": var l; l = String(b).split(","); return 0 <= m(l, String(c)); case "_le": return Number(b) <= Number(c); case "_lt": return Number(b) < Number(c); case "_re": var p; var r = a.ignore_case ? "i" : void 0; try { var n = String(c) + r, t = Bn.get(n); t || (t = new RegExp(c, r), Bn.set(n, t)); p = t.test(b) } catch (q) { p = !1 } return p; case "_sw": return 0 == String(b).indexOf(String(c)); case "_um": return Cn(b, c)
        }return !1
    }; var Fn = encodeURI, Y = encodeURIComponent, Gn = md; var Hn = function (a, b) { if (!a) return !1; var c = je(le(a), "host"); if (!c) return !1; for (var d = 0; b && d < b.length; d++) { var e = b[d] && b[d].toLowerCase(); if (e) { var f = c.length - e.length; 0 < f && "." != e.charAt(0) && (f--, e = "." + e); if (0 <= f && c.indexOf(e, f) == f) return !0 } } return !1 };
    var In = function (a, b, c) { for (var d = {}, e = !1, f = 0; a && f < a.length; f++)a[f] && a[f].hasOwnProperty(b) && a[f].hasOwnProperty(c) && (d[a[f][b]] = a[f][c], e = !0); return e ? d : null }; function op() { return G.gaGlobal = G.gaGlobal || {} } var pp = function () { var a = op(); a.hid = a.hid || Da(); return a.hid }, qp = function (a, b) { var c = op(); if (void 0 == c.vid || b && !c.from_cookie) c.vid = a, c.from_cookie = b }; var Zp = window, $p = document, aq = function (a) { var b = Zp._gaUserPrefs; if (b && b.ioo && b.ioo() || a && !0 === Zp["ga-disable-" + a]) return !0; try { var c = Zp.external; if (c && c._gaUserPrefs && "oo" == c._gaUserPrefs) return !0 } catch (f) { } for (var d = of("AMP_TOKEN", String($p.cookie), !0), e = 0; e < d.length; e++)if ("$OPT_OUT" == d[e]) return !0; return $p.getElementById("__gaOptOutExtension") ? !0 : !1 }; var bq = {}; function dq(a) { delete a.eventModel[E.xb]; fq(a.eventModel) }
    var fq = function (a) { Ia(a, function (c) { "_" === c.charAt(0) && delete a[c] }); var b = a[E.ma] || {}; Ia(b, function (c) { "_" === c.charAt(0) && delete b[c] }) }; var iq = function (a, b, c) { hl(b, c, a) }, jq = function (a, b, c) { hl(b, c, a, !0) }, qq = function (a, b) { };
    function kq(a, b) { } var Z = { g: {} };

    Z.g.gtagha = ["google"], function () { (function (a) { Z.__gtagha = a; Z.__gtagha.h = "gtagha"; Z.__gtagha.i = !0; Z.__gtagha.priorityOverride = 0 })(function (a) { I(a.vtp_gtmOnSuccess) }) }();

    Z.g.e = ["google"], function () { (function (a) { Z.__e = a; Z.__e.h = "e"; Z.__e.i = !0; Z.__e.priorityOverride = 0 })(function (a) { return String(ff(a.vtp_gtmEventId, "event")) }) }();

    Z.g.v = ["google"], function () { (function (a) { Z.__v = a; Z.__v.h = "v"; Z.__v.i = !0; Z.__v.priorityOverride = 0 })(function (a) { var b = a.vtp_name; if (!b || !b.replace) return !1; var c = Sm(b.replace(/\\\./g, "."), a.vtp_dataLayerVersion || 1), d = void 0 !== c ? c : a.vtp_defaultValue; bn(d, "v", a.vtp_gtmEventId); return d }) }();

    Z.g.rep = ["google"], function () { (function (a) { Z.__rep = a; Z.__rep.h = "rep"; Z.__rep.i = !0; Z.__rep.priorityOverride = 0 })(function (a) { var b; switch (Zg(a.vtp_containerId).prefix) { case "AW": b = hk; break; case "DC": b = tk; break; case "GF": b = yk; break; case "HA": b = Dk; break; case "UA": b = Xk; break; default: I(a.vtp_gtmOnFailure); return }I(a.vtp_gtmOnSuccess); gl(a.vtp_containerId, b, a.vtp_remoteConfig || {}) }) }();



    Z.g.cid = ["google"], function () { (function (a) { Z.__cid = a; Z.__cid.h = "cid"; Z.__cid.i = !0; Z.__cid.priorityOverride = 0 })(function () { return Ie.D }) }();



    Z.g.gtagaw = ["google"], function () { (function (a) { Z.__gtagaw = a; Z.__gtagaw.h = "gtagaw"; Z.__gtagaw.i = !0; Z.__gtagaw.priorityOverride = 0 })(function (a) { var b = "AW-" + String(a.vtp_conversionId); hl(String(a.vtp_eventName), a.vtp_eventData || {}, a.vtp_conversionLabel ? b + "/" + String(a.vtp_conversionLabel) : b); I(a.vtp_gtmOnSuccess) }) }();

    Z.g.get = ["google"], function () { (function (a) { Z.__get = a; Z.__get.h = "get"; Z.__get.i = !0; Z.__get.priorityOverride = 0 })(function (a) { var b = a.vtp_settings; (a.vtp_deferrable ? jq : iq)(String(b.streamId), String(a.vtp_eventName), b.eventParameters || {}); a.vtp_gtmOnSuccess() }) }();


    Z.g.gtagfl = [], function () { (function (a) { Z.__gtagfl = a; Z.__gtagfl.h = "gtagfl"; Z.__gtagfl.i = !0; Z.__gtagfl.priorityOverride = 0 })(function (a) { I(a.vtp_gtmOnSuccess) }) }();

    Z.g.gtaggf = ["google"], function () { (function (a) { Z.__gtaggf = a; Z.__gtaggf.h = "gtaggf"; Z.__gtaggf.i = !0; Z.__gtaggf.priorityOverride = 0 })(function (a) { I(a.vtp_gtmOnSuccess) }) }();



    Z.g.gtagua = ["google"], function () { (function (a) { Z.__gtagua = a; Z.__gtagua.h = "gtagua"; Z.__gtagua.i = !0; Z.__gtagua.priorityOverride = 0 })(function (a) { I(a.vtp_gtmOnSuccess) }) }();


    var rq = {}; rq.macro = function (a) { if (um.jd.hasOwnProperty(a)) return um.jd[a] }, rq.onHtmlSuccess = um.cf(!0), rq.onHtmlFailure = um.cf(!1); rq.dataLayer = bf; rq.callback = function (a) { Te.hasOwnProperty(a) && ya(Te[a]) && Te[a](); delete Te[a] }; rq.bootstrap = 0; rq._spx = !1; function sq() { M[Ie.D] = rq; Ta(Ue, Z.g); Qb = Qb || um; Rb = bc }
    function tq() {
        vd.gtag_cs_api = !0; M = G.google_tag_manager = G.google_tag_manager || {}; Rj(); if (M[Ie.D]) { var a = M.zones; a && a.unregisterChild(Ie.D); } else {
            for (var b = data.resource || {}, c = b.macros || [], d = 0; d < c.length; d++)Jb.push(c[d]);
            for (var e = b.tags || [], f = 0; f < e.length; f++)Mb.push(e[f]); for (var h = b.predicates || [], k = 0; k < h.length; k++)Lb.push(h[k]); for (var l = b.rules || [], p = 0; p < l.length; p++) { for (var r = l[p], n = {}, t = 0; t < r.length; t++)n[r[t][0]] = Array.prototype.slice.call(r[t], 1); Kb.push(n) } Ob = Z; Pb = Dn; sq(); tm(); Jh = !1; Kh = 0; if ("interactive" == H.readyState && !H.createEventObject || "complete" == H.readyState) Mh(); else {
                nd(H, "DOMContentLoaded", Mh); nd(H, "readystatechange", Mh); if (H.createEventObject && H.documentElement.doScroll) {
                    var q = !0; try { q = !G.frameElement } catch (w) { } q &&
                        Nh()
                } nd(G, "load", Mh)
            } zl = !1; "complete" === H.readyState ? Bl() : nd(G, "load", Bl); a: { if (!Gi) break a; G.setInterval(Hi, 864E5); } Re = (new Date).getTime(); rq.bootstrap = Re;
        }
    }
    (function (a) {
        if (!G["__TAGGY_INSTALLED"]) { var b = !1; if (H.referrer) { var c = le(H.referrer); b = "cct.google" === ie(c, "host") } if (!b) { var d = qf("googTaggyReferrer"); b = d.length && d[0].length } b && (G["__TAGGY_INSTALLED"] = !0, jd("https://cct.google/taggy/agent.js")) } var f = function () { var p = G["google.tagmanager.debugui2.queue"]; p || (p = [], G["google.tagmanager.debugui2.queue"] = p, jd("https://www.googletagmanager.com/debug/bootstrap")); return p }, h = "x" === je(G.location, "query", !1, void 0, "gtm_debug"); if (!h && H.referrer) { var k = le(H.referrer); h = "tagassistant.google.com" === ie(k, "host") } if (!h) { var l = qf("__TAG_ASSISTANT"); h = l.length && l[0].length } G.__TAG_ASSISTANT_API && (h = !0); h && bd ? f().push({
            messageType: "CONTAINER_STARTING",
            data: { scriptSource: bd, resume: function () { a() } }
        }) : a()
    })(tq);

})()