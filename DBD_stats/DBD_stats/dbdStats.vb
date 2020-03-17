Public Class dbdStatsFRM
    Dim baseDropdownSource As New List(Of String) From
    {"N/A", "None", ""}

    Dim flashlightAddons As New List(Of String) From
        {"None", "Wide Lens", "Power Bulb", "Leather Grip", "Battery",
        "TIR Optic", "Rubber Grip", "Low Amp Filament", "Heavy Duty Battery",
        "Focus Lens", "Long Life Battery", "Intense Halogen",
        "High-End Sapphire Lens", "Odd Bulb"}

    Dim keyAddons As New List(Of String) From
        {"None", "Prayer Rope", "Scratched Pearl", "Prayer Beads",
        "Eroded Token", "Gold Token", "Weaved Ring", "Milky Glass",
        "Blood Amber", "Unique Wedding Ring"}

    Dim mapAddons As New List(Of String) From
        {"None", "Map Addendum", "Yellow Wire", "Unusual Stamp", "Retardant Jelly",
        "Red Twine", "Glass Bead", "Odd Stamp", "Black Silk Cord", "Crystal Bead"}

    Dim medkitAddons As New List(Of String) From
        {"None", "Rubber Gloves", "Butterfly Tape", "Bandages", "Sponge",
        "Self Adherent Wrap", "Needle & Thread", "Medical Scissors", "Gauze Roll",
        "Surgical Suture", "Gel Dressings", "Abdominal Dressing", "Styptic Agent",
        "Anti-Haemorrhagic Syringe"}

    Dim toolboxAddons As New List(Of String) From
        {"None", "Spring Clamp", "Scraps", "Clean Rag", "Wire Spool", "Socket Swivels",
        "Protective Gloves", "Instructions", "Grip Wrench", "Cutting Wire", "Hacksaw",
        "Brand New Part"}

    Dim trapperAddons As New List(Of String) From
        {"None", "Trapper Sack", "Trapper Gloves", "Strong Coil Spring", "Padded Jaws", "Trapper Bag",
        "Trap Setters", "Serrated Jaws", "Logwood Dye", "4-Coil Spring Kit", "Wax Brick",
        "Tar Bottle", "Setting Tools", "Secondary Coil", "Rusted Jaws", "Stitched Bag", "Oily Coil",
        "Honing Stone", "Fastening Tools", "Iridescent Stone", "Bloody Coil"}

    Dim hagAddons As New List(Of String) From
        {"None", "Rope Necklet", "Powdered Eggshell", "Dead Fly Mud", "Bog Water", "Pussy Willow Catkins",
        "Half Eggshell", "Dragonfly Wings", "Cypress Necklet", "Bloodied Water", "Willow Wreath",
        "Swamp Orchid Necklet", "Dried Cicada", "Cracked Turtle Egg", "Bloodied Mud", "Scarred hand",
        "Rusty Shackles", "Grandmas Heart", "Disfigured Ear", "Waterlogged Shoe", "Mint Rag"}

    Dim bubbaAddons As New List(Of String) From
        {"None", "Vegetable Oil", "Spark Plug", "Chainsaw File", "Speed Limiter", "Shop Lubricant",
        "Primer Bulb", "Long Guide Bar", "Knife Scratches", "Homemade Muffler", "Grisly Chains",
        "Depth Gauge Rake", "Chilli", "The Grease", "The Beasts Marks", "Rusted Chains", "Light Chassis",
        "Carburettor Tuning Guide", "Begrimed Chains", "Award Winning Chilli"}

    Dim doctorAddons As New List(Of String) From
        {"None", "Mouldy Electrode", "Maple Knight", "Order - Class I", "Calm - Class I", "Polished Electrode",
        "Restraint - Class II", "Order - Class II", "Discipline - Class II", "Calm - Class II", "Interview tape",
        "High Stimulus Electrode", "Restraint - Class III", "Obedience - Class III", "Discipline - Class III",
        "Restraint - Carters Notes", "Order - Carters Notes", "Discipline - Carters Notes",
        "Calm - Carters Notes", "Iridescent Queen", "Iridescent King"}

    Dim billyAddons As New List(Of String) From
        {"None", "Vegetable Oil", "Spark Plug", "Chainsaw File", "Spiked Boots", "Speed Limiter",
        "Shop Lubricant", "Primer Bulb", "Long Guide bar", "Homemade Muffler", "Grisly Chains",
        "Depth Gauge Rake", "Death Engravings", "The Thompsons Mix", "Rusted Chains", "Light Chassis",
        "Doom Engravings", "Carburettor Tuning Guide", "Thompsons Moonshine", "Begrimed Chains"}

    Dim freddyAddons As New List(Of String) From
        {"None", "Wool Shirt", "Sheep Block", "Kid's Drawing", "Garden Rake", "Prototype Claws",
        "Outdoor Rope", "Nancys Sketch", "Green Dress", "Cat Block", "Unicorn Block", "Paint Thinner",
        "Nancys Masterpiece", "Jump Rope", "Blue Dress", "Pill Bottle", "Swing Chains", "Class Photo",
        "Z Block", "Red Paint Brush", "Black Box"}

    Dim shapeAddons As New List(Of String) From
        {"None", "Tacky Earrings", "Boyfriends Memo", "Blond hair", "Reflective Fragment", "Memorial Flower",
        "Jewellery", "Hair Brush", "Glass Fragment", "Dead Rabbit", "Mirror Shard", "Judiths Journal",
        "Jewellery Box", "J Myers Memorial", "Hair Bow", "Vanity Mirror", "Tombstone Piece", "Scratched Mirror",
        "Lock of Hair", "Judith's Tombstone", "Fragrant Tuft of Hair"}

    Dim legionAddons As New List(Of String) From
        {"None", "Smiley Face Pin", "Scratched Ruler", "Mischief List", "Friendship Bracelet", "Never-Sleep Pills",
        "Mural Sketch", "Julies Mix Tape", "Etched Ruler", "Defaced Smiley Pin", "The Legion Pin", "Susies Mix Tape",
        "Stolen Sketch Book", "Nasty Blade", "Joeys Mix tape", "Stab Wounds Study", "Franks Mix Tape",
        "Filthy Blade", "Cold Dirt", "Iridescent Button", "Fuming Mix Tape"}

    Dim huntressAddons As New List(Of String) From
        {"None", "Coarse Stone", "Berus Toxin", "Bandaged Haft", "Amanita Toxin", "Yew Seed Brew",
        "Shiny Pin", "Oak Haft", "Manna Grass Braid", "Leather Loop", "Fine Stone", "Deerskin Gloves",
        "Yew Seed Concoction", "Venomous Concoction", "Rusty Head", "Pungent Phial", "Flower Babushka",
        "Infantry Belt", "Glowing Concoction", "Begrimed Head", "Iridescent Head"}

    Dim pigAddons As New List(Of String) From
        {"None", "Workshop Grease", "Shattered Syringe", "Johns Medical File", "Combat Straps",
        "Video Tape", "Utility Blades", "Razor Wires", "Last Will", "Face Mask", "Slow-Release Toxin",
        "Rusty Attachment", "Jigsaws Annotated Plan", "Interlocking Razor", "Bag of Gears", "Tampered Timer",
        "Jigsaws Sketch", "Crate of Gears", "Amandas Secret", "Rules Set No.2", "Amandas Letter"}

    Dim ghostfaceAddons As New List(Of String) From
        {"None", "Philly", "Walleyes Matchbook", "Headlines Cut-Outs", "Cheap Cologne", "Telephoto lens",
        "Reusable Cinch Straps", "Olsens Journal", "Olsens Address Book", "Marked Map", "Olsens Wallet",
        "Leather Knife Sheath", "Lasting Perfume", "Knife Belt Clip", "Chewed Pen", "Victims Detailed Routine",
        "Night Vision Monocular", "Drop Leg Knife Sheath", "Drivers License", "Ghost Face Caught On Tape",
        "Outdoor Security Camera"}

    Dim demoAddons As New List(Of String) From
        {"None", "Rotten Pumpkin", "Black heart", "Rat Liver", "Rat Tail", "Sticky Lining",
        "Viscous Webbing", "Rotten Green Tripe", "Mews Guts", "Barbs Glasses", "Elevens Soda",
        "Thorny Vines", "Brass Case Lighter", "Violet Waxcap", "Deer Lung", "Lifeguard Whistle",
        "Vermillion Webcap", "Upside Down Resin", "Unknown Egg", "Leprose Lichen", "Red Moss"}

    Dim nurseAddons As New List(Of String) From
        {"None", "Wooden Horse", "White Nit Comb", "Plaid Flannel", "Metal Spoons", "Pocket Watch", "Dull Bracelet",
        "Dark Cincture", "Catatonic Boys Treasure", "Bad Man Keepsake", "Spasmodic Breath", "Heavy Panting",
        "Fragile Wheeze", "Ataxic Respiration", "Anxious Gasp", "Kavanaughs Last Breath", "Jenners Last Breath",
        "Campbells Last Breath", "Bad Mans Last Breath", "Torn Bookmark", "Matchbox"}

    Dim clownAddons As New List(Of String) From
        {"None", "Smelly Inner Soles", "Robin Feather", "Fingerless Parade Gloves", "Ether 5 Vol%",
        "Thich Cork Stopper", "Sticky Soda Bottle", "Starling Feather", "Solvent Jug",
        "Kerosene Can", "VHS Porn", "Sulphuric Acid Vial", "Flask of Bleach", "Ether 10 Vol%",
        "Bottle Of Chloroform", "Garish Make-up Kit", "Ether 15 Vol%", "Cigar Box", "Cheap Gin Bottle",
        "Tattoos Middle Finger", "Redhead's Pinky Finger"}

    Dim plagueAddons As New List(Of String) From
        {"None", "Prayer Tablet Fragment", "Olibanum Incense", "Limestone Seal", "Healing Salve",
        "Prophlytic Amulet", "Potent Tincture", "Haematite Seal", "Emetic Potion", "Blessed Apple",
        "Rubbing Oil", "Infected Emetic", "Incensed Ointment", "Exorcism Amulet", "Ashen Apple",
        "Worship Tablet", "Vile Emetic", "Severed Toe", "Devotees Amulet", "Iridescent Seal", "Black Incense"}

    Dim wraithAddons As New List(Of String) From
        {"None", "The Serpent - Soot", "The Hound - Soot", "The Ghost - Soot", "The Beast - Soot",
        "Bone Clapper", "Blink - Mud", "Windstorm - Mud", "Swift Hunt - Mud", "Blind Warrior - Mud",
        "Windstorm - White", "Swift Hunt - White", "Shadow Dance - White", "Blink - White",
        "Blind Warrior - White", "Windstorm - Blood", "Swift Hunt - Blood", "Shadow Dance - Blood", "All Seeing - Blood",
        "Coxcombed Clapper", "All Seeing - Spirit"}

    Dim spiritAddons As New List(Of String) From
        {"None", "Zori", "Shiawase Amulet", "Origami Crane", "Gifted Bamboo Comb", "White Hair Ribbon",
        "Rins Broken Watch", "Muddy Sports Day Cap", "Kaiun Talisman", "Juniper Bonsai", "Rusty Flute",
        "Katsumori Talisman", "Katana Tsuba", "Dirty Uwabaki", "Bloody Hair Brooch", "Yakuyoke Amulet",
        "Wakizashi Saya", "Prayer Beads Bracelet", "Dried Cherry Blossom", "Mother-Daughter Ring", "Fathers Glasses"}

    Dim oniAddons As New List(Of String) From
        {"None", "Yakuyoke Talisman", "Rotting Rope", "Cracked Sakazuki", "Blackened Toenail",
        "Polished Maedate", "Ink Lion", "Chipped Saihai", "Child's Wooden Sword", "Bloody Sash",
        "Yamaoka Sashimono", "Wooden Oni Mask", "Shattered Wakizashi", "Scalped Topknot",
        "Kanai-Anzen Talisman", "Tear Soaked Tenugui", "Splintered Hull", "Lion Fang", "Akitos Crutch",
        "Renjiros Bloody Glove", "Iridescent Family Crest"}

    Dim slingerAddons As New List(Of String) From {
        "Spit Polish Rag", "Snake Oil", "Rickety Chain", "Modified Ammo Belt", "Rusted Spike", "Poison Oak Leaves", "Marshal's Badge", "Jaw Smasher",
        "Chewing Tobacco", "Warden's Keys", "Wanted Poster", "Tin Oil Can", "Honey Locust Thorns", "Bayshore's Gold Tooth", "Prison Chain", "Gold Creek Whiskey",
        "Bayshore's Cigar", "Barbed Wire", "Iridescent Coin", "Hellshire Iron"}

    Dim gameStarted As Boolean = False

    Dim gensComplete As Integer = 0

    Dim gameStartTime As Date

    Dim s1copy, s2copy, s3copy, s4copy, killercopy As New List(Of String)

    Private Sub s1itemCMB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles s1itemCMB.SelectedIndexChanged
        Dim item As String = s1itemCMB.Text
        s1addonTwoCMB.DataSource = Nothing
        Select Case item
            Case "Flashlight", "Sport Flashlight", "Utility Flashlight", "Will O Wisp"
                s1addonOneCMB.Enabled = True
                s1addonTwoCMB.Enabled = True
                s1addonOneCMB.DataSource = flashlightAddons
                s1copy.Clear()
                s1copy.AddRange(flashlightAddons)
                s1addonTwoCMB.DataSource = s1copy
                s1addonOneCMB.SelectedIndex = 0
                s1addonTwoCMB.SelectedIndex = 0
            Case "Broken Key", "Dull Key", "Skeleton Key"
                s1addonOneCMB.Enabled = True
                s1addonTwoCMB.Enabled = True
                s1addonOneCMB.DataSource = keyAddons
                s1copy.Clear()
                s1copy.AddRange(keyAddons)
                s1addonTwoCMB.DataSource = s1copy
                s1addonOneCMB.SelectedIndex = 0
                s1addonTwoCMB.SelectedIndex = 0
            Case "Map", "Rainbow Map"
                s1addonOneCMB.Enabled = True
                s1addonTwoCMB.Enabled = True
                s1addonOneCMB.DataSource = mapAddons
                s1copy.Clear()
                s1copy.AddRange(mapAddons)
                s1addonTwoCMB.DataSource = s1copy
                s1addonOneCMB.SelectedIndex = 0
                s1addonTwoCMB.SelectedIndex = 0
            Case "Camping Aid Kit", "First Aid Kit", "Emergency Med-Kit", "Ranger Med-kit", "All Hallows Eve Lunchbox"
                s1addonOneCMB.Enabled = True
                s1addonTwoCMB.Enabled = True
                s1addonOneCMB.DataSource = medkitAddons
                s1copy.Clear()
                s1copy.AddRange(medkitAddons)
                s1addonTwoCMB.DataSource = s1copy
                s1addonOneCMB.SelectedIndex = 0
                s1addonTwoCMB.SelectedIndex = 0
            Case "Worn-Out Tools", "Toolbox", "Mechanics Toolbox", "Commodius Toolbox", "Engineers Toolbox", "Alex's Toolbox"
                s1addonOneCMB.Enabled = True
                s1addonTwoCMB.Enabled = True
                s1addonOneCMB.DataSource = toolboxAddons
                s1copy.Clear()
                s1copy.AddRange(toolboxAddons)
                s1addonTwoCMB.DataSource = s1copy
                s1addonOneCMB.SelectedIndex = 0
                s1addonTwoCMB.SelectedIndex = 0
            Case Else
                s1addonOneCMB.Enabled = False
                s1addonTwoCMB.Enabled = False
                s1addonOneCMB.DataSource = baseDropdownSource
                s1addonTwoCMB.DataSource = baseDropdownSource
                s1addonOneCMB.SelectedIndex = 0
                s1addonTwoCMB.SelectedIndex = 0
        End Select

    End Sub

    Private Sub s2itemCMB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles s2itemCMB.SelectedIndexChanged
        Dim item As String = s2itemCMB.Text
        s2addonTwoCMB.DataSource = Nothing
        Select Case item
            Case "Flashlight", "Sport Flashlight", "Utility Flashlight", "Will O Wisp"
                s2addonOneCMB.Enabled = True
                s2addonTwoCMB.Enabled = True
                s2addonOneCMB.DataSource = flashlightAddons
                s2copy.Clear()
                s2copy.AddRange(flashlightAddons)
                s2addonTwoCMB.DataSource = s2copy
                s2addonOneCMB.SelectedIndex = 0
                s2addonTwoCMB.SelectedIndex = 0
            Case "Broken Key", "Dull Key", "Skeleton Key"
                s2addonOneCMB.Enabled = True
                s2addonTwoCMB.Enabled = True
                s2addonOneCMB.DataSource = keyAddons
                s2copy.Clear()
                s2copy.AddRange(keyAddons)
                s2addonTwoCMB.DataSource = s2copy
                s2addonOneCMB.SelectedIndex = 0
                s2addonTwoCMB.SelectedIndex = 0
            Case "Map", "Rainbow Map"
                s2addonOneCMB.Enabled = True
                s2addonTwoCMB.Enabled = True
                s2addonOneCMB.DataSource = mapAddons
                s2copy.Clear()
                s2copy.AddRange(mapAddons)
                s2addonTwoCMB.DataSource = s2copy
                s2addonOneCMB.SelectedIndex = 0
                s2addonTwoCMB.SelectedIndex = 0
            Case "Camping Aid Kit", "First Aid Kit", "Emergency Med-Kit", "Ranger Med-kit", "All Hallows Eve Lunchbox"
                s2addonOneCMB.Enabled = True
                s2addonTwoCMB.Enabled = True
                s2addonOneCMB.DataSource = medkitAddons
                s2copy.Clear()
                s2copy.AddRange(medkitAddons)
                s2addonTwoCMB.DataSource = s2copy
                s2addonOneCMB.SelectedIndex = 0
                s2addonTwoCMB.SelectedIndex = 0
            Case "Worn-Out Tools", "Toolbox", "Mechanics Toolbox", "Commodius Toolbox", "Engineers Toolbox", "Alex's Toolbox"
                s2addonOneCMB.Enabled = True
                s2addonTwoCMB.Enabled = True
                s2addonOneCMB.DataSource = toolboxAddons
                s2copy.Clear()
                s2copy.AddRange(toolboxAddons)
                s2addonTwoCMB.DataSource = s2copy
                s2addonOneCMB.SelectedIndex = 0
                s2addonTwoCMB.SelectedIndex = 0
            Case Else
                s2addonOneCMB.Enabled = False
                s2addonTwoCMB.Enabled = False
                s2addonOneCMB.DataSource = baseDropdownSource
                s2addonTwoCMB.DataSource = baseDropdownSource
                s2addonOneCMB.SelectedIndex = 0
                s2addonTwoCMB.SelectedIndex = 0
        End Select

    End Sub

    Private Sub s3itemCMB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles s3itemCMB.SelectedIndexChanged
        Dim item As String = s3itemCMB.Text
        s3addonTwoCMB.DataSource = Nothing
        Select Case item
            Case "Flashlight", "Sport Flashlight", "Utility Flashlight", "Will O Wisp"
                s3addonOneCMB.Enabled = True
                s3addonTwoCMB.Enabled = True
                s3addonOneCMB.DataSource = flashlightAddons
                s3copy.Clear()
                s3copy.AddRange(flashlightAddons)
                s3addonTwoCMB.DataSource = s3copy
                s3addonOneCMB.SelectedIndex = 0
                s3addonTwoCMB.SelectedIndex = 0
            Case "Broken Key", "Dull Key", "Skeleton Key"
                s3addonOneCMB.Enabled = True
                s3addonTwoCMB.Enabled = True
                s3addonOneCMB.DataSource = keyAddons
                s3copy.Clear()
                s3copy.AddRange(keyAddons)
                s3addonTwoCMB.DataSource = s3copy
                s3addonOneCMB.SelectedIndex = 0
                s3addonTwoCMB.SelectedIndex = 0
            Case "Map", "Rainbow Map"
                s3addonOneCMB.Enabled = True
                s3addonTwoCMB.Enabled = True
                s3addonOneCMB.DataSource = mapAddons
                s3copy.Clear()
                s3copy.AddRange(mapAddons)
                s3addonTwoCMB.DataSource = s3copy
                s3addonOneCMB.SelectedIndex = 0
                s3addonTwoCMB.SelectedIndex = 0
            Case "Camping Aid Kit", "First Aid Kit", "Emergency Med-Kit", "Ranger Med-kit", "All Hallows Eve Lunchbox"
                s3addonOneCMB.Enabled = True
                s3addonTwoCMB.Enabled = True
                s3addonOneCMB.DataSource = medkitAddons
                s3copy.Clear()
                s3copy.AddRange(medkitAddons)
                s3addonTwoCMB.DataSource = s3copy
                s3addonOneCMB.SelectedIndex = 0
                s3addonTwoCMB.SelectedIndex = 0
            Case "Worn-Out Tools", "Toolbox", "Mechanics Toolbox", "Commodius Toolbox", "Engineers Toolbox", "Alex's Toolbox"
                s3addonOneCMB.Enabled = True
                s3addonTwoCMB.Enabled = True
                s3addonOneCMB.DataSource = toolboxAddons
                s3copy.Clear()
                s3copy.AddRange(toolboxAddons)
                s3addonTwoCMB.DataSource = s3copy
                s3addonOneCMB.SelectedIndex = 0
                s3addonTwoCMB.SelectedIndex = 0
            Case Else
                s3addonOneCMB.Enabled = False
                s3addonTwoCMB.Enabled = False
                s3addonOneCMB.DataSource = baseDropdownSource
                s3addonTwoCMB.DataSource = baseDropdownSource
                s3addonOneCMB.SelectedIndex = 0
                s3addonTwoCMB.SelectedIndex = 0
        End Select

    End Sub

    Private Sub s4itemCMB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles s4itemCMB.SelectedIndexChanged
        Dim item As String = s4itemCMB.Text
        s4addonTwoCMB.DataSource = Nothing
        Select Case item
            Case "Flashlight", "Sport Flashlight", "Utility Flashlight", "Will O Wisp"
                s4addonOneCMB.Enabled = True
                s4addonTwoCMB.Enabled = True
                s4addonOneCMB.DataSource = flashlightAddons
                s4copy.Clear()
                s4copy.AddRange(flashlightAddons)
                s4addonTwoCMB.DataSource = s4copy
                s4addonOneCMB.SelectedIndex = 0
                s4addonTwoCMB.SelectedIndex = 0
            Case "Broken Key", "Dull Key", "Skeleton Key"
                s4addonOneCMB.Enabled = True
                s4addonTwoCMB.Enabled = True
                s4addonOneCMB.DataSource = keyAddons
                s4copy.Clear()
                s4copy.AddRange(keyAddons)
                s4addonTwoCMB.DataSource = s4copy
                s4addonOneCMB.SelectedIndex = 0
                s4addonTwoCMB.SelectedIndex = 0
            Case "Map", "Rainbow Map"
                s4addonOneCMB.Enabled = True
                s4addonTwoCMB.Enabled = True
                s4addonOneCMB.DataSource = mapAddons
                s4copy.Clear()
                s4copy.AddRange(mapAddons)
                s4addonTwoCMB.DataSource = s4copy
                s4addonOneCMB.SelectedIndex = 0
                s4addonTwoCMB.SelectedIndex = 0
            Case "Camping Aid Kit", "First Aid Kit", "Emergency Med-Kit", "Ranger Med-kit", "All Hallows Eve Lunchbox"
                s4addonOneCMB.Enabled = True
                s4addonTwoCMB.Enabled = True
                s4addonOneCMB.DataSource = medkitAddons
                s4copy.Clear()
                s4copy.AddRange(medkitAddons)
                s4addonTwoCMB.DataSource = s4copy
                s4addonOneCMB.SelectedIndex = 0
                s4addonTwoCMB.SelectedIndex = 0
            Case "Worn-Out Tools", "Toolbox", "Mechanics Toolbox", "Commodius Toolbox", "Engineers Toolbox", "Alex's Toolbox"
                s4addonOneCMB.Enabled = True
                s4addonTwoCMB.Enabled = True
                s4addonOneCMB.DataSource = toolboxAddons
                s4copy.Clear()
                s4copy.AddRange(toolboxAddons)
                s4addonTwoCMB.DataSource = s4copy
                s4addonOneCMB.SelectedIndex = 0
                s4addonTwoCMB.SelectedIndex = 0
            Case Else
                s4addonOneCMB.Enabled = False
                s4addonTwoCMB.Enabled = False
                s4addonOneCMB.DataSource = baseDropdownSource
                s4addonTwoCMB.DataSource = baseDropdownSource
                s4addonOneCMB.SelectedIndex = 0
                s4addonTwoCMB.SelectedIndex = 0
        End Select
    End Sub

    Private Sub killerCMB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles killerCMB.SelectedIndexChanged
        Dim killer As String = killerCMB.Text
        killerAddonOneCMB.Enabled = True
        killerAddonTwoCMB.Enabled = True
        killerAddonTwoCMB.DataSource = Nothing
        Select Case killer
            Case "Trapper"
                killerAddonOneCMB.DataSource = trapperAddons

                killercopy.Clear()
                killercopy.AddRange(trapperAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Hag"
                killerAddonOneCMB.DataSource = hagAddons
                killercopy.Clear()
                killercopy.AddRange(hagAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Cannibal"
                killerAddonOneCMB.DataSource = bubbaAddons
                killercopy.Clear()
                killercopy.AddRange(bubbaAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Clown"
                killerAddonOneCMB.DataSource = clownAddons
                killercopy.Clear()
                killercopy.AddRange(clownAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Demogorgon"
                killerAddonOneCMB.DataSource = demoAddons
                killercopy.Clear()
                killercopy.AddRange(demoAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Doctor"
                killerAddonOneCMB.DataSource = doctorAddons
                killercopy.Clear()
                killercopy.AddRange(doctorAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Ghost Face"
                killerAddonOneCMB.DataSource = ghostfaceAddons
                killercopy.Clear()
                killercopy.AddRange(ghostfaceAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Hillbilly"
                killerAddonOneCMB.DataSource = billyAddons
                killercopy.Clear()
                killercopy.AddRange(billyAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Huntress"
                killerAddonOneCMB.DataSource = huntressAddons
                killercopy.Clear()
                killercopy.AddRange(huntressAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Legion"
                killerAddonOneCMB.DataSource = legionAddons
                killercopy.Clear()
                killercopy.AddRange(legionAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Nightmare"
                killerAddonOneCMB.DataSource = freddyAddons
                killercopy.Clear()
                killercopy.AddRange(freddyAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Nurse"
                killerAddonOneCMB.DataSource = nurseAddons
                killercopy.Clear()
                killercopy.AddRange(nurseAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Oni"
                killerAddonOneCMB.DataSource = oniAddons
                killercopy.Clear()
                killercopy.AddRange(oniAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Pig"
                killerAddonOneCMB.DataSource = pigAddons
                killercopy.Clear()
                killercopy.AddRange(pigAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Plague"
                killerAddonOneCMB.DataSource = plagueAddons
                killercopy.Clear()
                killercopy.AddRange(plagueAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Shape"
                killerAddonOneCMB.DataSource = shapeAddons
                killercopy.Clear()
                killercopy.AddRange(shapeAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Spirit"
                killerAddonOneCMB.DataSource = spiritAddons
                killercopy.Clear()
                killercopy.AddRange(spiritAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Wraith"
                killerAddonOneCMB.DataSource = wraithAddons
                killercopy.Clear()
                killercopy.AddRange(wraithAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case "Deathslinger"
                killerAddonOneCMB.DataSource = slingerAddons
                killercopy.Clear()
                killercopy.AddRange(slingerAddons)
                killerAddonTwoCMB.DataSource = killercopy
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
            Case Else
                killerAddonOneCMB.DataSource = baseDropdownSource
                killerAddonTwoCMB.DataSource = baseDropdownSource
                killerAddonOneCMB.SelectedIndex = 0
                killerAddonTwoCMB.SelectedIndex = 0
        End Select
    End Sub

    Private Sub dbdStatsFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each cmbControl As Control In Me.Controls
            If TypeOf cmbControl Is ComboBox Then
                If CType(cmbControl, ComboBox).Items.Count > 0 Then
                    CType(cmbControl, ComboBox).SelectedIndex = 0
                Else
                    CType(cmbControl, ComboBox).DataSource = baseDropdownSource
                    CType(cmbControl, ComboBox).SelectedIndex = 0
                End If
            End If
        Next
    End Sub

    Private Sub dbdStatsFRM_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Dim pressTime As TimeSpan = Date.Now - gameStartTime
        Dim mins, seconds As Integer
        mins = pressTime.Minutes
        seconds = pressTime.Seconds
        Select Case e.KeyCode
            Case Keys.Space
                If Not gameStarted Then
                    gameStarted = True
                    gameStartTime = Date.Now
                Else
                    GenPopped(mins, seconds)
                End If
            Case Keys.H
                If numOfHooksNUD.Value < 12 Then
                    numOfHooksNUD.Value += 1
                Else
                    MessageBox.Show("Too many hooks, you've killed everyone already")
                End If
            Case Keys.G
                gameTimeOutLBL.Text = String.Format("{0}:{1}", mins, seconds)
                gensComplete = 7

        End Select
    End Sub

    Private Sub GenPopped(mins As Integer, seconds As Integer)
        gensComplete += 1
        Select Case gensComplete
            Case 1
                genOneOutLBL.Text = String.Format("{0}:{1}", mins, seconds)
            Case 2
                genTwoOutLBL.Text = String.Format("{0}:{1}", mins, seconds)
            Case 3
                genThreeOutLBL.Text = String.Format("{0}:{1}", mins, seconds)
            Case 4
                genFourOutLBL.Text = String.Format("{0}:{1}", mins, seconds)
            Case 5
                genFiveOutLBL.Text = String.Format("{0}:{1}", mins, seconds)
            Case 6
                gateOpenOutLBL.Text = String.Format("{0}:{1}", mins, seconds)
            Case Else
                MessageBox.Show("The Game is over dude, Use the print or clear buttons to restart", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub ClearVals()
        gameStarted = False
        gensComplete = 0
        genOneOutLBL.Text = "N/A"
        genTwoOutLBL.Text = "N/A"
        genThreeOutLBL.Text = "N/A"
        genFourOutLBL.Text = "N/A"
        genFiveOutLBL.Text = "N/A"
        gateOpenOutLBL.Text = "N/A"
        gameTimeOutLBL.Text = "N/A"
        For Each cmbControl As Control In Me.Controls
            If TypeOf cmbControl Is ComboBox Then
                If CType(cmbControl, ComboBox).Items.Count > 0 Then
                    CType(cmbControl, ComboBox).SelectedIndex = 0
                Else
                    CType(cmbControl, ComboBox).DataSource = baseDropdownSource
                    CType(cmbControl, ComboBox).SelectedIndex = 0
                End If
            End If
        Next
        s1rankNUD.Value = 1
        s2rankNUD.Value = 1
        s3rankNUD.Value = 1
        s4rankNUD.Value = 1
        killerRankNUD.Value = 1
        numOfHooksNUD.Value = 0
    End Sub

    Private Sub clearBTN_Click(sender As Object, e As EventArgs) Handles clearBTN.Click
        ClearVals()
    End Sub

    Private Sub printBTN_Click(sender As Object, e As EventArgs) Handles printBTN.Click
        Dim output As String = ""

        Dim survivors As String(,)
        survivors = New String(3, 10) {{s1survivorCMB.Text, s1itemCMB.Text, s1addonOneCMB.Text, s1addonTwoCMB.Text, s1perkOneCMB.Text, s1perkTwoCMB.Text, s1perkThreeCMB.Text, s1perkFourCMB.Text, s1offeringCMB.Text, s1endStateCMB.Text, s1rankNUD.Value},
                                       {s2survivorCMB.Text, s2itemCMB.Text, s2addonOneCMB.Text, s2addonTwoCMB.Text, s2perkOneCMB.Text, s2perkTwoCMB.Text, s2perkThreeCMB.Text, s2perkFourCMB.Text, s2offeringCMB.Text, s2endStateCMB.Text, s2rankNUD.Value},
                                       {s3survivorCMB.Text, s3itemCMB.Text, s3addonOneCMB.Text, s3addonTwoCMB.Text, s3perkOneCMB.Text, s3perkTwoCMB.Text, s3perkThreeCMB.Text, s3perkFourCMB.Text, s3offeringCMB.Text, s3endStateCMB.Text, s3rankNUD.Value},
                                       {s4survivorCMB.Text, s4itemCMB.Text, s4addonOneCMB.Text, s4addonTwoCMB.Text, s4perkOneCMB.Text, s4perkTwoCMB.Text, s4perkThreeCMB.Text, s4perkFourCMB.Text, s4offeringCMB.Text, s4endStateCMB.Text, s4rankNUD.Value}}
        Dim killerstuff As String()
        killerstuff = New String(10) {killerCMB.Text, killerAddonOneCMB.Text, killerAddonTwoCMB.Text,
                                      killerPerkOneCMB.Text, killerPerkTwoCMB.Text, killerPerkThreeCMB.Text, killerPerkFourCMB.Text,
                                      killerOfferingCMB.Text, numOfHooksNUD.Value, killerPipStateCMB.Text, killerRankNUD.Value}

        Dim timesmap As String()
        timesmap = New String(7) {mapCMB.Text, genOneOutLBL.Text, genTwoOutLBL.Text, genThreeOutLBL.Text, genFourOutLBL.Text, genFiveOutLBL.Text,
                                  gateOpenOutLBL.Text, gameTimeOutLBL.Text}

        For i = 0 To 10
            output &= survivors(0, i) & ","
        Next

        For i = 0 To 7
            output &= timesmap(i) & ","
        Next

        For i = 0 To 10
            output &= killerstuff(i) & ","
        Next

        For outer = 1 To 3
            output &= vbNewLine
            For inner = 0 To 10
                If outer = 3 And inner = 10 Then
                    output &= survivors(outer, inner) & vbNewLine
                Else
                    output &= survivors(outer, inner) & ","
                End If
            Next
        Next

        My.Computer.FileSystem.WriteAllText("C:\DBDstats\DBDstats.csv", output, True)
        ClearVals()
        MessageBox.Show("The text was added successfully to the file!", "Write Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
