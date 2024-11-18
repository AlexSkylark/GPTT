# Gradual Progression Tech Tree
A KSP tech tree designed with 3 main goals:

-	Take better advantage of some major part packs, in particular BDB and Nertea’s mods, without being held back by concerns over compatibility with different mod combinations.
- Make tech progression a bit more “rational”, focusing on increased capabilities rather than arbitrary distinctions of size that inconvenience the player without substantially affecting what they can achieve.
-	Give an RP-1-like feeling of early progression, advancing gradually from early sounding rockets to first satellites to crewed spaceflight, while still working with the actual gameplay balance rather than getting caught up in historical reenactment.

Aside from start, the tree is created using completely new nodes, meaning that only supported mods will appear on the tree, though as a fallback option all the stock techs are still present as hidden nodes on the left side of the tree with 1 science cost each. The supported mods list is recorded in the mods spreadsheet, but to start out with these mods are highly recommended to properly fill out the tree and play as intended:
- Bluedog Design Bureau
- USI Sounding Rockets
- Near Future Technology collection
- Far Future
- Kerbal Atomics
- Cryo Engines
- Restock
- Station Parts Expansion Redux
- Heat Control
- Airplane Plus
- USI-LS

These mods also integrate quite well with the tree:
- Dmagic
- SCANsat
- Coatl Aerospace Probes Plus
- Feline Utility Rovers
- System Heat
- WaterDrinker
- Deep Freeze
- Mk2 Expansion
- Supplementary Electric Engines
- Kerbal Planetary Base Systems
- MkIV Spaceplane System
- Civilian Popuation Modernized
- OSE Workshop Reworked
- Malemute
- Planetside Exploration Technologies MMSEV

And these mods are also variously well supported:
- Taerobee
- Tantares
- TantaresLV
- TantaresSP
- TantaresSAF
- Rational Resources
- GemstoneLV
- JX2 Antenna
- Simple Adjustable Fairings
- HullcamVDS Continued
- Tundra Exploration
- Kerbal Reusability Expansion
- SXT Continued
- SpaceY Heavy Lifters
- KIS
- KAS
- Tarsier Space Technology
- Research Bodies
- Buffalo 2
- MOLE
- RealChute
- QuizTech Aero Pack Continued
- Mk3 Stockalike Expansion
- Mk-X
- RLA Reborn
- SSR Microsat
- Fuji
- Bumblebee
- Universal Storage 2
- Bon Voyage
- Sterling Systems
- Ground Construction
- Extraplanetary Launchpads
- Breaking Ground
- Making History
- MKS
- Firespitter
- Kerbal Foundries 2
- Sandcastle

Again, see the spreadsheet for links and details

There are no extra parts or modifications added except that there are two tweaks to science value returns:
- stock_magnetometer_nerf.cfg reduces the stock magnetometer science return from 45 to 5 to be more in line with stock magnetometers, because it seemed silly to split them up
- usi_science_nerf.cfg reduces the return of the USI sounding rockets science parts from 25 to 4, to be more balanced as entry-level science parts.

GPTT was created using ksp-techtree-edit (https://github.com/linuxgurugamer/ksp-techtree-edit), but modified to use ModuleManager instead to remove the dependency on the YongeTech plugin (which has issues with Kerbal Construction Time), by saving the tech nodes as a stock tree, adding a patch to hide the stock nodes, and converting the part unlocks into a single MM patch using the make_gptt_patch.py python script; admittedly a somewhat clunky approach but it makes it easier to keep editing the tree with the editor. The Additional Patches folder holds (in addition to the 2 scripts above) various patches to cover parts added as MM patches, which don't appear in the editor, and part upgrades for at least a few mods.

GPTT is distributed under a CC-BY-NC-SA license (and redistributes tech icons made by Nertea for CTT under the same license), meaning variants or derivatives can be made so long as any previous authors are credited, the use is non-commercial, and the same license is used--and in fact I actively encourage this, because there's every chance I may move on to other projects in the future, and the tree has to be actively maintained to keep or expand mod support. I've added a design document to give a sense of my original intentions for the tree layout to guide any such efforts, though don't feel bound by that if you want to go in a different direction. In the meantime though, you can use pull requests to add any patches, and I am open to adding support for any requested mods.
