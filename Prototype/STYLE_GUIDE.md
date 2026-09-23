# DVLD Prototype — Style Guide

Reference for restyling the remaining ~25 forms not individually prototyped here, so the
rest of the app can be brought in line with this design system consistently. Everything
below is implemented in code under `DVLD.Prototype/Theme/` and `DVLD.Prototype/Common/` —
treat this document as the map to that code, not a separate source of truth.

## 1. Palette

Formalizes the original app's two hardcoded, never-named colors (navy chrome + IndianRed
accents) into a full palette. Defined in `Theme/AppTheme.cs`.

| Token | Hex | Usage |
|---|---|---|
| `Navy` | `#242538` | Primary brand/chrome — menu bars, primary buttons, grid headers, MDI background |
| `NavyLight` | `#363852` | Hover/active state for navy chrome |
| `Accent` (IndianRed) | `#CD5C5C` | Page titles, "value" labels — the app's existing de-facto accent, now centralized |
| `AccentDark` | `#B04242` | Hover state for accent-colored elements |
| `Success` | `#2EA05C` | Success dialog icon/title |
| `Warning` | `#E0A800` | Confirm/Caution dialog icon |
| `Danger` | `#C43E3E` | Failure dialog, danger buttons, delete actions |
| `Surface` | `#FFFFFF` | Form/card background |
| `SurfaceAlt` | `#F5F7FA` | Alternating grid rows, secondary panels |
| `Border` | `#E0E2E8` | Grid lines, secondary button borders |
| `TextPrimary` | `#242538` | Body text |
| `TextSecondary` | `#6E7180` | Captions, helper text |
| `TextOnNavy` | `#F5F7FA` | Text/icons on navy backgrounds |

## 2. Type scale

Resolves the original "Segoe UI Semibold + Tahoma" mix onto one family (Segoe UI, with the
Semibold weight where the original used it for emphasis). All exposed as `AppTheme.Font*`
properties — never hardcode a `new Font(...)` in a screen.

| Token | Family / size / weight | Usage |
|---|---|---|
| `FontPageTitle` | Segoe UI Semibold, 20pt, Bold | Screen titles (`lblTitle`) |
| `FontSectionTitle` | Segoe UI Semibold, 13pt, Bold | GroupBox headers |
| `FontCaption` | Segoe UI, 10.5pt, Bold | Field captions (e.g. "Full Name") |
| `FontValue` | Segoe UI Semibold, 10.5pt, Bold, IndianRed | Field values — replaces the original's "??" placeholder convention with `N/A`/actual data |
| `FontBody` | Segoe UI, 9.5pt, Regular | Textboxes, grid cells, general body text |
| `FontSmall` | Segoe UI, 8.5pt, Regular | LinkLabels, checkboxes, helper text |
| `FontButton` | Segoe UI, 9.5pt, Bold | Button text |

## 3. Spacing

4/8/16/24/32px scale (`AppTheme.SpaceXS`…`SpaceXL`). Screens in this prototype use it loosely
as a mental grid (24px screen margins, ~44px row height in info cards) rather than a strict
layout engine, since these are hand-authored `Designer.cs` files, not a flex/grid system.

## 4. Form sizing convention

**One fixed convention, replacing the FixedToolWindow/Sizable/SizableToolWindow/None mix
documented in the inventory report:**

- Every screen inherits `BaseForm`, which sets `AutoScaleMode = AutoScaleMode.None`,
  `BackColor = AppTheme.Surface`, `Font = AppTheme.FontBody`, `StartPosition = CenterScreen`.
  (`AutoScaleMode.None` was a deliberate choice over `Font`/`Dpi`: these Designer.cs files
  are hand-authored, not round-tripped through the Visual Studio designer at a captured
  system font/DPI, so Font/Dpi auto-scaling has no correct baseline to scale from — it was
  found in testing to silently push docked panels outside the visible client area. `None`
  keeps every hand-tuned pixel layout WYSIWYG.)
- List/grid screens (Manage People, Manage Application Types, etc.) and the MainForm shell
  use `FormBorderStyle.FixedSingle`, non-maximizable, sized to content.
- Detail/dialog screens call the `UseDialogSizing()` helper on `BaseForm`, which applies the
  same `FixedSingle` convention plus disables Min/Max boxes — one rule for every dialog
  instead of the original's FixedToolWindow/Sizable/SizableToolWindow/None mix.
- The login screen keeps its own distinct navy side-panel branding (as in the original) but
  now uses standard `FixedSingle` chrome instead of a fully custom borderless window — the
  bespoke close button and hand-drawn underline textboxes were a one-off maintenance burden
  documented in the report; this prototype keeps the distinct branding but not the bespoke
  chrome.

## 5. Icon set

**No external assets, no NuGet icon packages.** Every icon is a small flat vector drawn in
code by `Common/IconGlyph.cs` (a `Control` subclass) from a `Common/IconKind` enum, tinted
via `AppTheme`. This was a deliberate substitute for a bitmap or icon-font set: guessing at
Segoe MDL2/Fluent glyph codepoints from memory risks shipping wrong/blank "tofu box" glyphs,
and this keeps the whole icon set license-free, resolution-independent, and trivially
recolorable to match any future palette tweak.

Usage: `new IconGlyph { Icon = IconKind.Person, Tint = AppTheme.Navy, Size = new Size(18,18) }`.

| IconKind | Concept | Used on |
|---|---|---|
| `Person` / `PersonAdd` | A person / add a person | Person cards, ManagePeopleForm title |
| `People` | Multiple people | ManagePeopleForm title |
| `IdCard` | ID/record fields (Person ID, National No, License ID, App ID) | Person & license cards, ApplicationTypes |
| `Mail` | Email field | Person card |
| `Phone` | Phone field | Person card |
| `Address` | Address field | Person card |
| `Calendar` | Date fields | Person/license cards, applications |
| `Globe` | Country field / International License | Person card, frmNewInternationalLicense title |
| `Gender` | Gender field | Person & license cards |
| `Car` | Vehicle/license concept | License cards, MainForm/login branding mark |
| `Search` | Search actions | (reserved for future search-only buttons) |
| `Money` | Fees fields | Application/license fee fields |
| `Lock` | Password / Users module | frmListUsers title |
| `Test` | Tests module | frmTestAppointments title |
| `History` | License/record history | (reserved for history views) |
| `Warning` | Caution dialog, "Is Detained?" | AppMessageDialog (Confirm), license card |
| `Close` | Close/cancel | (reserved — most Close buttons use text only) |
| `Save` | Save actions | (reserved) |
| `Edit` | Edit actions | (reserved) |
| `Delete` | Delete actions | (reserved) |
| `Check` | Success, "Is Active?" | AppMessageDialog (Success), license card |
| `Error` | Failure dialog | AppMessageDialog (Failure) |
| `Info` | Informational | AppMessageDialog default |
| `SignOut` | Sign out | MainForm Account Settings menu (icon reserved; menu is text-only in this prototype) |
| `ChevronRight` | Navigation affordance | (reserved) |
| `Filter` | Filter bar | (reserved — filter bars currently use a caption label instead) |

To extend: add a case to `IconKind` and a matching `case` in `IconGlyph.DrawIcon()` using the
existing primitives (`DrawEllipse`, `DrawLine`, `DrawPolygon`, `GraphicsPath`) — no asset
pipeline needed.

## 6. The 3-variant message dialog

Replaces all 129 raw `MessageBox.Show(...)` call sites with `Common/AppMessageDialog`,
formalizing the original app's own de-facto convention (see inventory report §"MessageBox
Inventory"):

```csharp
AppMessageDialog.Confirm(this, "Are you sure you want to apply changes?", "Caution"); // -> bool
AppMessageDialog.Success(this, "Changed Applied Successfully", "Success");
AppMessageDialog.Failure(this, "An error occurred, changes didn't apply.", "Failure");
```

| Variant | Icon | Title color | Buttons |
|---|---|---|---|
| `Confirm` | `Warning`, amber | `TextPrimary` | OK (primary/navy) + Cancel (secondary) |
| `Success` | `Check`, green | `Success` green | OK (primary/navy) |
| `Failure` | `Error`, red | `Danger` red | OK (danger/red) |

Demoed live in `frmManageApplicationTypes` ("Edit" → Confirm → Success; "Simulate Save
Failure" → Confirm → Failure) and reused throughout every other screen's Save/Delete/Cancel
flows — including fixing the report's flagged UX gap where `ManagePeopleForm` and
`frmListUsers` deleted records with no confirmation at all.

## 7. Applying this to the remaining ~25 forms

1. Inherit `BaseForm` instead of `Form`.
2. Replace every hardcoded `Color`/`Font` with the matching `AppTheme` token.
3. Replace bitmap/PictureBox icons with `IconGlyph` + the closest `IconKind` (add a new one
   if genuinely no match — see §5).
4. Replace every `MessageBox.Show(...)` call with the matching `AppMessageDialog.Confirm /
   Success / Failure` call, mapping the original's `Title` almost 1:1 (the original's
   vocabulary — "Caution"/"Confirm changes" → "Success" → "Failure"/"Error" — already matches
   `MessageKind` cleanly).
5. Apply `AppTheme.StyleGrid(dgv)` to every `DataGridView` instead of leaving default/
   inconsistent `BackgroundColor` (resolves the White vs. `SystemColors.ButtonHighlight`
   inconsistency documented in the report).
6. Pick `FixedSingle` (list/shell screens) or `UseDialogSizing()` (detail/dialog screens) —
   never leave `FormBorderStyle` unset.
7. While restyling a screen, fix the specific bugs the inventory report calls out for it
   (negative-Y clipped labels, mismatched icons, uncustomized `this.Text`, missing delete
   confirmations, etc.) rather than carrying them forward — this prototype fixed every such
   issue on the screens it touched, and the same standard should apply screen-by-screen as
   the rest of the app is restyled.
