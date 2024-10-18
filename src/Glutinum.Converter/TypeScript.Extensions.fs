[<AutoOpen>]
module TypeScriptExtensions

open TypeScript

type Ts.SyntaxKind with

    member this.Name =
        match this with
        | Ts.SyntaxKind.Unknown -> "Unknown"
        | Ts.SyntaxKind.EndOfFileToken -> "EndOfFileToken"
        | Ts.SyntaxKind.SingleLineCommentTrivia -> "SingleLineCommentTrivia"
        | Ts.SyntaxKind.MultiLineCommentTrivia -> "MultiLineCommentTrivia"
        | Ts.SyntaxKind.NewLineTrivia -> "NewLineTrivia"
        | Ts.SyntaxKind.WhitespaceTrivia -> "WhitespaceTrivia"
        | Ts.SyntaxKind.ShebangTrivia -> "ShebangTrivia"
        | Ts.SyntaxKind.ConflictMarkerTrivia -> "ConflictMarkerTrivia"
        | Ts.SyntaxKind.NonTextFileMarkerTrivia -> "NonTextFileMarkerTrivia"
        | Ts.SyntaxKind.NumericLiteral -> "NumericLiteral"
        | Ts.SyntaxKind.BigIntLiteral -> "BigIntLiteral"
        | Ts.SyntaxKind.StringLiteral -> "StringLiteral"
        | Ts.SyntaxKind.JsxText -> "JsxText"
        | Ts.SyntaxKind.JsxTextAllWhiteSpaces -> "JsxTextAllWhiteSpaces"
        | Ts.SyntaxKind.RegularExpressionLiteral -> "RegularExpressionLiteral"
        | Ts.SyntaxKind.NoSubstitutionTemplateLiteral ->
            "NoSubstitutionTemplateLiteral"
        | Ts.SyntaxKind.TemplateHead -> "TemplateHead"
        | Ts.SyntaxKind.TemplateMiddle -> "TemplateMiddle"
        | Ts.SyntaxKind.TemplateTail -> "TemplateTail"
        | Ts.SyntaxKind.OpenBraceToken -> "OpenBraceToken"
        | Ts.SyntaxKind.CloseBraceToken -> "CloseBraceToken"
        | Ts.SyntaxKind.OpenParenToken -> "OpenParenToken"
        | Ts.SyntaxKind.CloseParenToken -> "CloseParenToken"
        | Ts.SyntaxKind.OpenBracketToken -> "OpenBracketToken"
        | Ts.SyntaxKind.CloseBracketToken -> "CloseBracketToken"
        | Ts.SyntaxKind.DotToken -> "DotToken"
        | Ts.SyntaxKind.DotDotDotToken -> "DotDotDotToken"
        | Ts.SyntaxKind.SemicolonToken -> "SemicolonToken"
        | Ts.SyntaxKind.CommaToken -> "CommaToken"
        | Ts.SyntaxKind.QuestionDotToken -> "QuestionDotToken"
        | Ts.SyntaxKind.LessThanToken -> "LessThanToken"
        | Ts.SyntaxKind.LessThanSlashToken -> "LessThanSlashToken"
        | Ts.SyntaxKind.GreaterThanToken -> "GreaterThanToken"
        | Ts.SyntaxKind.LessThanEqualsToken -> "LessThanEqualsToken"
        | Ts.SyntaxKind.GreaterThanEqualsToken -> "GreaterThanEqualsToken"
        | Ts.SyntaxKind.EqualsEqualsToken -> "EqualsEqualsToken"
        | Ts.SyntaxKind.ExclamationEqualsToken -> "ExclamationEqualsToken"
        | Ts.SyntaxKind.EqualsEqualsEqualsToken -> "EqualsEqualsEqualsToken"
        | Ts.SyntaxKind.ExclamationEqualsEqualsToken ->
            "ExclamationEqualsEqualsToken"
        | Ts.SyntaxKind.EqualsGreaterThanToken -> "EqualsGreaterThanToken"
        | Ts.SyntaxKind.PlusToken -> "PlusToken"
        | Ts.SyntaxKind.MinusToken -> "MinusToken"
        | Ts.SyntaxKind.AsteriskToken -> "AsteriskToken"
        | Ts.SyntaxKind.AsteriskAsteriskToken -> "AsteriskAsteriskToken"
        | Ts.SyntaxKind.SlashToken -> "SlashToken"
        | Ts.SyntaxKind.PercentToken -> "PercentToken"
        | Ts.SyntaxKind.PlusPlusToken -> "PlusPlusToken"
        | Ts.SyntaxKind.MinusMinusToken -> "MinusMinusToken"
        | Ts.SyntaxKind.LessThanLessThanToken -> "LessThanLessThanToken"
        | Ts.SyntaxKind.GreaterThanGreaterThanToken ->
            "GreaterThanGreaterThanToken"
        | Ts.SyntaxKind.GreaterThanGreaterThanGreaterThanToken ->
            "GreaterThanGreaterThanGreaterThanToken"
        | Ts.SyntaxKind.AmpersandToken -> "AmpersandToken"
        | Ts.SyntaxKind.BarToken -> "BarToken"
        | Ts.SyntaxKind.CaretToken -> "CaretToken"
        | Ts.SyntaxKind.ExclamationToken -> "ExclamationToken"
        | Ts.SyntaxKind.TildeToken -> "TildeToken"
        | Ts.SyntaxKind.AmpersandAmpersandToken -> "AmpersandAmpersandToken"
        | Ts.SyntaxKind.BarBarToken -> "BarBarToken"
        | Ts.SyntaxKind.QuestionToken -> "QuestionToken"
        | Ts.SyntaxKind.ColonToken -> "ColonToken"
        | Ts.SyntaxKind.AtToken -> "AtToken"
        | Ts.SyntaxKind.QuestionQuestionToken -> "QuestionQuestionToken"
        | Ts.SyntaxKind.BacktickToken -> "BacktickToken"
        | Ts.SyntaxKind.HashToken -> "HashToken"
        | Ts.SyntaxKind.EqualsToken -> "EqualsToken"
        | Ts.SyntaxKind.PlusEqualsToken -> "PlusEqualsToken"
        | Ts.SyntaxKind.MinusEqualsToken -> "MinusEqualsToken"
        | Ts.SyntaxKind.AsteriskEqualsToken -> "AsteriskEqualsToken"
        | Ts.SyntaxKind.AsteriskAsteriskEqualsToken ->
            "AsteriskAsteriskEqualsToken"
        | Ts.SyntaxKind.SlashEqualsToken -> "SlashEqualsToken"
        | Ts.SyntaxKind.PercentEqualsToken -> "PercentEqualsToken"
        | Ts.SyntaxKind.LessThanLessThanEqualsToken ->
            "LessThanLessThanEqualsToken"
        | Ts.SyntaxKind.GreaterThanGreaterThanEqualsToken ->
            "GreaterThanGreaterThanEqualsToken"
        | Ts.SyntaxKind.GreaterThanGreaterThanGreaterThanEqualsToken ->
            "GreaterThanGreaterThanGreaterThanEqualsToken"
        | Ts.SyntaxKind.AmpersandEqualsToken -> "AmpersandEqualsToken"
        | Ts.SyntaxKind.BarEqualsToken -> "BarEqualsToken"
        | Ts.SyntaxKind.BarBarEqualsToken -> "BarBarEqualsToken"
        | Ts.SyntaxKind.AmpersandAmpersandEqualsToken ->
            "AmpersandAmpersandEqualsToken"
        | Ts.SyntaxKind.QuestionQuestionEqualsToken ->
            "QuestionQuestionEqualsToken"
        | Ts.SyntaxKind.CaretEqualsToken -> "CaretEqualsToken"
        | Ts.SyntaxKind.Identifier -> "Identifier"
        | Ts.SyntaxKind.PrivateIdentifier -> "PrivateIdentifier"
        | Ts.SyntaxKind.BreakKeyword -> "BreakKeyword"
        | Ts.SyntaxKind.CaseKeyword -> "CaseKeyword"
        | Ts.SyntaxKind.CatchKeyword -> "CatchKeyword"
        | Ts.SyntaxKind.ClassKeyword -> "ClassKeyword"
        | Ts.SyntaxKind.ConstKeyword -> "ConstKeyword"
        | Ts.SyntaxKind.ContinueKeyword -> "ContinueKeyword"
        | Ts.SyntaxKind.DebuggerKeyword -> "DebuggerKeyword"
        | Ts.SyntaxKind.DefaultKeyword -> "DefaultKeyword"
        | Ts.SyntaxKind.DeleteKeyword -> "DeleteKeyword"
        | Ts.SyntaxKind.DoKeyword -> "DoKeyword"
        | Ts.SyntaxKind.ElseKeyword -> "ElseKeyword"
        | Ts.SyntaxKind.EnumKeyword -> "EnumKeyword"
        | Ts.SyntaxKind.ExportKeyword -> "ExportKeyword"
        | Ts.SyntaxKind.ExtendsKeyword -> "ExtendsKeyword"
        | Ts.SyntaxKind.FalseKeyword -> "FalseKeyword"
        | Ts.SyntaxKind.FinallyKeyword -> "FinallyKeyword"
        | Ts.SyntaxKind.ForKeyword -> "ForKeyword"
        | Ts.SyntaxKind.FunctionKeyword -> "FunctionKeyword"
        | Ts.SyntaxKind.IfKeyword -> "IfKeyword"
        | Ts.SyntaxKind.ImportKeyword -> "ImportKeyword"
        | Ts.SyntaxKind.InKeyword -> "InKeyword"
        | Ts.SyntaxKind.InstanceOfKeyword -> "InstanceOfKeyword"
        | Ts.SyntaxKind.NewKeyword -> "NewKeyword"
        | Ts.SyntaxKind.NullKeyword -> "NullKeyword"
        | Ts.SyntaxKind.ReturnKeyword -> "ReturnKeyword"
        | Ts.SyntaxKind.SuperKeyword -> "SuperKeyword"
        | Ts.SyntaxKind.SwitchKeyword -> "SwitchKeyword"
        | Ts.SyntaxKind.ThisKeyword -> "ThisKeyword"
        | Ts.SyntaxKind.ThrowKeyword -> "ThrowKeyword"
        | Ts.SyntaxKind.TrueKeyword -> "TrueKeyword"
        | Ts.SyntaxKind.TryKeyword -> "TryKeyword"
        | Ts.SyntaxKind.TypeOfKeyword -> "TypeOfKeyword"
        | Ts.SyntaxKind.VarKeyword -> "VarKeyword"
        | Ts.SyntaxKind.VoidKeyword -> "VoidKeyword"
        | Ts.SyntaxKind.WhileKeyword -> "WhileKeyword"
        | Ts.SyntaxKind.WithKeyword -> "WithKeyword"
        | Ts.SyntaxKind.ImplementsKeyword -> "ImplementsKeyword"
        | Ts.SyntaxKind.InterfaceKeyword -> "InterfaceKeyword"
        | Ts.SyntaxKind.LetKeyword -> "LetKeyword"
        | Ts.SyntaxKind.PackageKeyword -> "PackageKeyword"
        | Ts.SyntaxKind.PrivateKeyword -> "PrivateKeyword"
        | Ts.SyntaxKind.ProtectedKeyword -> "ProtectedKeyword"
        | Ts.SyntaxKind.PublicKeyword -> "PublicKeyword"
        | Ts.SyntaxKind.StaticKeyword -> "StaticKeyword"
        | Ts.SyntaxKind.YieldKeyword -> "YieldKeyword"
        | Ts.SyntaxKind.AbstractKeyword -> "AbstractKeyword"
        | Ts.SyntaxKind.AccessorKeyword -> "AccessorKeyword"
        | Ts.SyntaxKind.AsKeyword -> "AsKeyword"
        | Ts.SyntaxKind.AssertsKeyword -> "AssertsKeyword"
        | Ts.SyntaxKind.AssertKeyword -> "AssertKeyword"
        | Ts.SyntaxKind.AnyKeyword -> "AnyKeyword"
        | Ts.SyntaxKind.AsyncKeyword -> "AsyncKeyword"
        | Ts.SyntaxKind.AwaitKeyword -> "AwaitKeyword"
        | Ts.SyntaxKind.BooleanKeyword -> "BooleanKeyword"
        | Ts.SyntaxKind.ConstructorKeyword -> "ConstructorKeyword"
        | Ts.SyntaxKind.DeclareKeyword -> "DeclareKeyword"
        | Ts.SyntaxKind.GetKeyword -> "GetKeyword"
        | Ts.SyntaxKind.InferKeyword -> "InferKeyword"
        | Ts.SyntaxKind.IntrinsicKeyword -> "IntrinsicKeyword"
        | Ts.SyntaxKind.IsKeyword -> "IsKeyword"
        | Ts.SyntaxKind.KeyOfKeyword -> "KeyOfKeyword"
        | Ts.SyntaxKind.ModuleKeyword -> "ModuleKeyword"
        | Ts.SyntaxKind.NamespaceKeyword -> "NamespaceKeyword"
        | Ts.SyntaxKind.NeverKeyword -> "NeverKeyword"
        | Ts.SyntaxKind.OutKeyword -> "OutKeyword"
        | Ts.SyntaxKind.ReadonlyKeyword -> "ReadonlyKeyword"
        | Ts.SyntaxKind.RequireKeyword -> "RequireKeyword"
        | Ts.SyntaxKind.NumberKeyword -> "NumberKeyword"
        | Ts.SyntaxKind.ObjectKeyword -> "ObjectKeyword"
        | Ts.SyntaxKind.SatisfiesKeyword -> "SatisfiesKeyword"
        | Ts.SyntaxKind.SetKeyword -> "SetKeyword"
        | Ts.SyntaxKind.StringKeyword -> "StringKeyword"
        | Ts.SyntaxKind.SymbolKeyword -> "SymbolKeyword"
        | Ts.SyntaxKind.TypeKeyword -> "TypeKeyword"
        | Ts.SyntaxKind.UndefinedKeyword -> "UndefinedKeyword"
        | Ts.SyntaxKind.UniqueKeyword -> "UniqueKeyword"
        | Ts.SyntaxKind.UnknownKeyword -> "UnknownKeyword"
        | Ts.SyntaxKind.UsingKeyword -> "UsingKeyword"
        | Ts.SyntaxKind.FromKeyword -> "FromKeyword"
        | Ts.SyntaxKind.GlobalKeyword -> "GlobalKeyword"
        | Ts.SyntaxKind.BigIntKeyword -> "BigIntKeyword"
        | Ts.SyntaxKind.OverrideKeyword -> "OverrideKeyword"
        | Ts.SyntaxKind.OfKeyword -> "OfKeyword"
        | Ts.SyntaxKind.QualifiedName -> "QualifiedName"
        | Ts.SyntaxKind.ComputedPropertyName -> "ComputedPropertyName"
        | Ts.SyntaxKind.TypeParameter -> "TypeParameter"
        | Ts.SyntaxKind.Parameter -> "Parameter"
        | Ts.SyntaxKind.Decorator -> "Decorator"
        | Ts.SyntaxKind.PropertySignature -> "PropertySignature"
        | Ts.SyntaxKind.PropertyDeclaration -> "PropertyDeclaration"
        | Ts.SyntaxKind.MethodSignature -> "MethodSignature"
        | Ts.SyntaxKind.MethodDeclaration -> "MethodDeclaration"
        | Ts.SyntaxKind.ClassStaticBlockDeclaration ->
            "ClassStaticBlockDeclaration"
        | Ts.SyntaxKind.Constructor -> "Constructor"
        | Ts.SyntaxKind.GetAccessor -> "GetAccessor"
        | Ts.SyntaxKind.SetAccessor -> "SetAccessor"
        | Ts.SyntaxKind.CallSignature -> "CallSignature"
        | Ts.SyntaxKind.ConstructSignature -> "ConstructSignature"
        | Ts.SyntaxKind.IndexSignature -> "IndexSignature"
        | Ts.SyntaxKind.TypePredicate -> "TypePredicate"
        | Ts.SyntaxKind.TypeReference -> "TypeReference"
        | Ts.SyntaxKind.FunctionType -> "FunctionType"
        | Ts.SyntaxKind.ConstructorType -> "ConstructorType"
        | Ts.SyntaxKind.TypeQuery -> "TypeQuery"
        | Ts.SyntaxKind.TypeLiteral -> "TypeLiteral"
        | Ts.SyntaxKind.ArrayType -> "ArrayType"
        | Ts.SyntaxKind.TupleType -> "TupleType"
        | Ts.SyntaxKind.OptionalType -> "OptionalType"
        | Ts.SyntaxKind.RestType -> "RestType"
        | Ts.SyntaxKind.UnionType -> "UnionType"
        | Ts.SyntaxKind.IntersectionType -> "IntersectionType"
        | Ts.SyntaxKind.ConditionalType -> "ConditionalType"
        | Ts.SyntaxKind.InferType -> "InferType"
        | Ts.SyntaxKind.ParenthesizedType -> "ParenthesizedType"
        | Ts.SyntaxKind.ThisType -> "ThisType"
        | Ts.SyntaxKind.TypeOperator -> "TypeOperator"
        | Ts.SyntaxKind.IndexedAccessType -> "IndexedAccessType"
        | Ts.SyntaxKind.MappedType -> "MappedType"
        | Ts.SyntaxKind.LiteralType -> "LiteralType"
        | Ts.SyntaxKind.NamedTupleMember -> "NamedTupleMember"
        | Ts.SyntaxKind.TemplateLiteralType -> "TemplateLiteralType"
        | Ts.SyntaxKind.TemplateLiteralTypeSpan -> "TemplateLiteralTypeSpan"
        | Ts.SyntaxKind.ImportType -> "ImportType"
        | Ts.SyntaxKind.ObjectBindingPattern -> "ObjectBindingPattern"
        | Ts.SyntaxKind.ArrayBindingPattern -> "ArrayBindingPattern"
        | Ts.SyntaxKind.BindingElement -> "BindingElement"
        | Ts.SyntaxKind.ArrayLiteralExpression -> "ArrayLiteralExpression"
        | Ts.SyntaxKind.ObjectLiteralExpression -> "ObjectLiteralExpression"
        | Ts.SyntaxKind.PropertyAccessExpression -> "PropertyAccessExpression"
        | Ts.SyntaxKind.ElementAccessExpression -> "ElementAccessExpression"
        | Ts.SyntaxKind.CallExpression -> "CallExpression"
        | Ts.SyntaxKind.NewExpression -> "NewExpression"
        | Ts.SyntaxKind.TaggedTemplateExpression -> "TaggedTemplateExpression"
        | Ts.SyntaxKind.TypeAssertionExpression -> "TypeAssertionExpression"
        | Ts.SyntaxKind.ParenthesizedExpression -> "ParenthesizedExpression"
        | Ts.SyntaxKind.FunctionExpression -> "FunctionExpression"
        | Ts.SyntaxKind.ArrowFunction -> "ArrowFunction"
        | Ts.SyntaxKind.DeleteExpression -> "DeleteExpression"
        | Ts.SyntaxKind.TypeOfExpression -> "TypeOfExpression"
        | Ts.SyntaxKind.VoidExpression -> "VoidExpression"
        | Ts.SyntaxKind.AwaitExpression -> "AwaitExpression"
        | Ts.SyntaxKind.PrefixUnaryExpression -> "PrefixUnaryExpression"
        | Ts.SyntaxKind.PostfixUnaryExpression -> "PostfixUnaryExpression"
        | Ts.SyntaxKind.BinaryExpression -> "BinaryExpression"
        | Ts.SyntaxKind.ConditionalExpression -> "ConditionalExpression"
        | Ts.SyntaxKind.TemplateExpression -> "TemplateExpression"
        | Ts.SyntaxKind.YieldExpression -> "YieldExpression"
        | Ts.SyntaxKind.SpreadElement -> "SpreadElement"
        | Ts.SyntaxKind.ClassExpression -> "ClassExpression"
        | Ts.SyntaxKind.OmittedExpression -> "OmittedExpression"
        | Ts.SyntaxKind.ExpressionWithTypeArguments ->
            "ExpressionWithTypeArguments"
        | Ts.SyntaxKind.AsExpression -> "AsExpression"
        | Ts.SyntaxKind.NonNullExpression -> "NonNullExpression"
        | Ts.SyntaxKind.MetaProperty -> "MetaProperty"
        | Ts.SyntaxKind.SyntheticExpression -> "SyntheticExpression"
        | Ts.SyntaxKind.SatisfiesExpression -> "SatisfiesExpression"
        | Ts.SyntaxKind.TemplateSpan -> "TemplateSpan"
        | Ts.SyntaxKind.SemicolonClassElement -> "SemicolonClassElement"
        | Ts.SyntaxKind.Block -> "Block"
        | Ts.SyntaxKind.EmptyStatement -> "EmptyStatement"
        | Ts.SyntaxKind.VariableStatement -> "VariableStatement"
        | Ts.SyntaxKind.ExpressionStatement -> "ExpressionStatement"
        | Ts.SyntaxKind.IfStatement -> "IfStatement"
        | Ts.SyntaxKind.DoStatement -> "DoStatement"
        | Ts.SyntaxKind.WhileStatement -> "WhileStatement"
        | Ts.SyntaxKind.ForStatement -> "ForStatement"
        | Ts.SyntaxKind.ForInStatement -> "ForInStatement"
        | Ts.SyntaxKind.ForOfStatement -> "ForOfStatement"
        | Ts.SyntaxKind.ContinueStatement -> "ContinueStatement"
        | Ts.SyntaxKind.BreakStatement -> "BreakStatement"
        | Ts.SyntaxKind.ReturnStatement -> "ReturnStatement"
        | Ts.SyntaxKind.WithStatement -> "WithStatement"
        | Ts.SyntaxKind.SwitchStatement -> "SwitchStatement"
        | Ts.SyntaxKind.LabeledStatement -> "LabeledStatement"
        | Ts.SyntaxKind.ThrowStatement -> "ThrowStatement"
        | Ts.SyntaxKind.TryStatement -> "TryStatement"
        | Ts.SyntaxKind.DebuggerStatement -> "DebuggerStatement"
        | Ts.SyntaxKind.VariableDeclaration -> "VariableDeclaration"
        | Ts.SyntaxKind.VariableDeclarationList -> "VariableDeclarationList"
        | Ts.SyntaxKind.FunctionDeclaration -> "FunctionDeclaration"
        | Ts.SyntaxKind.ClassDeclaration -> "ClassDeclaration"
        | Ts.SyntaxKind.InterfaceDeclaration -> "InterfaceDeclaration"
        | Ts.SyntaxKind.TypeAliasDeclaration -> "TypeAliasDeclaration"
        | Ts.SyntaxKind.EnumDeclaration -> "EnumDeclaration"
        | Ts.SyntaxKind.ModuleDeclaration -> "ModuleDeclaration"
        | Ts.SyntaxKind.ModuleBlock -> "ModuleBlock"
        | Ts.SyntaxKind.CaseBlock -> "CaseBlock"
        | Ts.SyntaxKind.NamespaceExportDeclaration ->
            "NamespaceExportDeclaration"
        | Ts.SyntaxKind.ImportEqualsDeclaration -> "ImportEqualsDeclaration"
        | Ts.SyntaxKind.ImportDeclaration -> "ImportDeclaration"
        | Ts.SyntaxKind.ImportClause -> "ImportClause"
        | Ts.SyntaxKind.NamespaceImport -> "NamespaceImport"
        | Ts.SyntaxKind.NamedImports -> "NamedImports"
        | Ts.SyntaxKind.ImportSpecifier -> "ImportSpecifier"
        | Ts.SyntaxKind.ExportAssignment -> "ExportAssignment"
        | Ts.SyntaxKind.ExportDeclaration -> "ExportDeclaration"
        | Ts.SyntaxKind.NamedExports -> "NamedExports"
        | Ts.SyntaxKind.NamespaceExport -> "NamespaceExport"
        | Ts.SyntaxKind.ExportSpecifier -> "ExportSpecifier"
        | Ts.SyntaxKind.MissingDeclaration -> "MissingDeclaration"
        | Ts.SyntaxKind.ExternalModuleReference -> "ExternalModuleReference"
        | Ts.SyntaxKind.JsxElement -> "JsxElement"
        | Ts.SyntaxKind.JsxSelfClosingElement -> "JsxSelfClosingElement"
        | Ts.SyntaxKind.JsxOpeningElement -> "JsxOpeningElement"
        | Ts.SyntaxKind.JsxClosingElement -> "JsxClosingElement"
        | Ts.SyntaxKind.JsxFragment -> "JsxFragment"
        | Ts.SyntaxKind.JsxOpeningFragment -> "JsxOpeningFragment"
        | Ts.SyntaxKind.JsxClosingFragment -> "JsxClosingFragment"
        | Ts.SyntaxKind.JsxAttribute -> "JsxAttribute"
        | Ts.SyntaxKind.JsxAttributes -> "JsxAttributes"
        | Ts.SyntaxKind.JsxSpreadAttribute -> "JsxSpreadAttribute"
        | Ts.SyntaxKind.JsxExpression -> "JsxExpression"
        | Ts.SyntaxKind.JsxNamespacedName -> "JsxNamespacedName"
        | Ts.SyntaxKind.CaseClause -> "CaseClause"
        | Ts.SyntaxKind.DefaultClause -> "DefaultClause"
        | Ts.SyntaxKind.HeritageClause -> "HeritageClause"
        | Ts.SyntaxKind.CatchClause -> "CatchClause"
        | Ts.SyntaxKind.AssertClause -> "AssertClause"
        | Ts.SyntaxKind.AssertEntry -> "AssertEntry"
        | Ts.SyntaxKind.ImportTypeAssertionContainer ->
            "ImportTypeAssertionContainer"
        | Ts.SyntaxKind.PropertyAssignment -> "PropertyAssignment"
        | Ts.SyntaxKind.ShorthandPropertyAssignment ->
            "ShorthandPropertyAssignment"
        | Ts.SyntaxKind.SpreadAssignment -> "SpreadAssignment"
        | Ts.SyntaxKind.EnumMember -> "EnumMember"
        | Ts.SyntaxKind.UnparsedPrologue -> "UnparsedPrologue"
        | Ts.SyntaxKind.UnparsedPrepend -> "UnparsedPrepend"
        | Ts.SyntaxKind.UnparsedText -> "UnparsedText"
        | Ts.SyntaxKind.UnparsedInternalText -> "UnparsedInternalText"
        | Ts.SyntaxKind.UnparsedSyntheticReference ->
            "UnparsedSyntheticReference"
        | Ts.SyntaxKind.SourceFile -> "SourceFile"
        | Ts.SyntaxKind.Bundle -> "Bundle"
        | Ts.SyntaxKind.UnparsedSource -> "UnparsedSource"
        | Ts.SyntaxKind.InputFiles -> "InputFiles"
        | Ts.SyntaxKind.JSDocTypeExpression -> "JSDocTypeExpression"
        | Ts.SyntaxKind.JSDocNameReference -> "JSDocNameReference"
        | Ts.SyntaxKind.JSDocMemberName -> "JSDocMemberName"
        | Ts.SyntaxKind.JSDocAllType -> "JSDocAllType"
        | Ts.SyntaxKind.JSDocUnknownType -> "JSDocUnknownType"
        | Ts.SyntaxKind.JSDocNullableType -> "JSDocNullableType"
        | Ts.SyntaxKind.JSDocNonNullableType -> "JSDocNonNullableType"
        | Ts.SyntaxKind.JSDocOptionalType -> "JSDocOptionalType"
        | Ts.SyntaxKind.JSDocFunctionType -> "JSDocFunctionType"
        | Ts.SyntaxKind.JSDocVariadicType -> "JSDocVariadicType"
        | Ts.SyntaxKind.JSDocNamepathType -> "JSDocNamepathType"
        | Ts.SyntaxKind.JSDoc -> "JSDoc"
        | Ts.SyntaxKind.JSDocText -> "JSDocText"
        | Ts.SyntaxKind.JSDocTypeLiteral -> "JSDocTypeLiteral"
        | Ts.SyntaxKind.JSDocSignature -> "JSDocSignature"
        | Ts.SyntaxKind.JSDocLink -> "JSDocLink"
        | Ts.SyntaxKind.JSDocLinkCode -> "JSDocLinkCode"
        | Ts.SyntaxKind.JSDocLinkPlain -> "JSDocLinkPlain"
        | Ts.SyntaxKind.JSDocTag -> "JSDocTag"
        | Ts.SyntaxKind.JSDocAugmentsTag -> "JSDocAugmentsTag"
        | Ts.SyntaxKind.JSDocImplementsTag -> "JSDocImplementsTag"
        | Ts.SyntaxKind.JSDocAuthorTag -> "JSDocAuthorTag"
        | Ts.SyntaxKind.JSDocDeprecatedTag -> "JSDocDeprecatedTag"
        | Ts.SyntaxKind.JSDocClassTag -> "JSDocClassTag"
        | Ts.SyntaxKind.JSDocPublicTag -> "JSDocPublicTag"
        | Ts.SyntaxKind.JSDocPrivateTag -> "JSDocPrivateTag"
        | Ts.SyntaxKind.JSDocProtectedTag -> "JSDocProtectedTag"
        | Ts.SyntaxKind.JSDocReadonlyTag -> "JSDocReadonlyTag"
        | Ts.SyntaxKind.JSDocOverrideTag -> "JSDocOverrideTag"
        | Ts.SyntaxKind.JSDocCallbackTag -> "JSDocCallbackTag"
        | Ts.SyntaxKind.JSDocOverloadTag -> "JSDocOverloadTag"
        | Ts.SyntaxKind.JSDocEnumTag -> "JSDocEnumTag"
        | Ts.SyntaxKind.JSDocParameterTag -> "JSDocParameterTag"
        | Ts.SyntaxKind.JSDocReturnTag -> "JSDocReturnTag"
        | Ts.SyntaxKind.JSDocThisTag -> "JSDocThisTag"
        | Ts.SyntaxKind.JSDocTypeTag -> "JSDocTypeTag"
        | Ts.SyntaxKind.JSDocTemplateTag -> "JSDocTemplateTag"
        | Ts.SyntaxKind.JSDocTypedefTag -> "JSDocTypedefTag"
        | Ts.SyntaxKind.JSDocSeeTag -> "JSDocSeeTag"
        | Ts.SyntaxKind.JSDocPropertyTag -> "JSDocPropertyTag"
        | Ts.SyntaxKind.JSDocThrowsTag -> "JSDocThrowsTag"
        | Ts.SyntaxKind.JSDocSatisfiesTag -> "JSDocSatisfiesTag"
        | Ts.SyntaxKind.SyntaxList -> "SyntaxList"
        | Ts.SyntaxKind.NotEmittedStatement -> "NotEmittedStatement"
        | Ts.SyntaxKind.PartiallyEmittedExpression ->
            "PartiallyEmittedExpression"
        | Ts.SyntaxKind.CommaListExpression -> "CommaListExpression"
        | Ts.SyntaxKind.SyntheticReferenceExpression ->
            "SyntheticReferenceExpression"
        | Ts.SyntaxKind.Count -> "Count"
        | unknown -> $"Unknown {unknown}"